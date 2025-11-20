using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1
{
    internal class ElectionService : DBConnection
    {
        public int GetElectionId(string electionName)
        {
                var election = db.Elections.FirstOrDefault(e => e.ElectionName == electionName);
                return election != null ? election.ElectionId : -1;
        }
        public void AddElection(string electionName, string description, bool isActive, int departmentId)
        {
                Election newElection = new Election
                {
                    ElectionName = electionName,
                    Description = description,
                    Status = isActive,
                    DepartmentId = departmentId
                };
                db.Elections.Add(newElection);
                db.SaveChanges();
        }
        public List<ElectionDTO> GetElections()
        {
            var list = new List<ElectionDTO>();
            var elections =  db.Elections.Include(e => e.Candidates).Include(e => e.Department).Where(e => e.Status == false).ToList();

            foreach (var election in elections)
            {
                ElectionDTO electionDTO = new ElectionDTO()
                {
                    Election = election,
                    Department = election.Department,
                    Candidates = election.Candidates.ToList()
                };
                list.Add(electionDTO);
            }

            return list;
        }
        public List<ElectionDTO> GetOngoingElections()
        {
            var list = new List<ElectionDTO>();
            var elections = db.Elections.Include(e => e.Candidates).Include(e => e.Department).Where(e => e.Status == true && e.EndStatus == false).ToList();
            foreach (var election in elections)
                list.Add(GetElectionDepartmentPositions(election.ElectionId));
            return list;
        }

        public List<ElectionDTO> GetEndedElections()
        {
            var list = new List<ElectionDTO>();
                var elections = db.Elections.Include(e => e.Candidates).Include(e => e.Department).Include(e => e.Winners).Where(e => e.EndStatus == true && e.Status == true).ToList();
                
            foreach (var election in elections)
            {
                MessageBox.Show(""+election.Winners.Count());
                ElectionDTO electionDTO = new ElectionDTO()
                {
                    Election = election,
                    Department = election.Department,
                    Candidates = election.Candidates.ToList(),
                    Winners = election.Winners.ToList()
                };
                list.Add(electionDTO);
            }
            return list;
        }
        public Boolean DoesElectionAlreadyExisted(string electionName, int departmentId)
        {
                var election = db.Elections.FirstOrDefault(e => e.ElectionName == electionName || e.DepartmentId == departmentId && e.Status && e.EndStatus == false);
                if (election == null)
                    return false;
                return true;
        }
        public void UpdateElectionStatus(int electionId)
        {
            var election = db.Elections.FirstOrDefault(e => e.ElectionId == electionId);
            if (election != null)
            {
                election.Status = true;
                db.SaveChanges();
            }
 
        }
        public List<Election> GetActiveElections()
        {
                return db.Elections.Where(e => e.Status == true).ToList();
            
        }
        public List<Election> GetInactiveElections()
        {
                return db.Elections.Where(e => e.Status == false).ToList();
        }
        public void DeleteElection(int electionId)
        {
               db.Candidates.RemoveRange(db.Candidates.Where(c => c.ElectionId == electionId));
                db.Elections.RemoveRange(db.Elections.Where(e => e.ElectionId == electionId));
                db.SaveChanges();
        }
        public bool FindDepartmentActiveElection(int departmentId)
        {
                var hasActiveElection = db.Elections
                    .Any(e => e.DepartmentId == departmentId && e.Status == true);
                return hasActiveElection;  
        }
        public string GetElectionsCount()
        {
                return db.Elections.Count().ToString();
        }
        public void SetEndStatus(int electionId)
        {
            var election = db.Elections.FirstOrDefault(e => e.ElectionId == electionId);
            election.EndStatus = true;
            db.SaveChanges();
        }

        public ElectionDTO GetElectionDepartmentPositions(int electionId)
        {
            var election = from v in db.Elections
                        join d in db.Departments on v.DepartmentId equals d.DepartmentId
                        join c in db.Candidates on v.ElectionId equals c.ElectionId
                        where v.ElectionId  == electionId
                        select new ElectionDTO
                        {
                            Department = d,
                            Election = v,
                            Candidates = v.Candidates.ToList(),
                            Positions = v.Candidates.Where(ca => ca.ElectionId == v.ElectionId).Select(ca => ca.Position).Distinct().ToList()
                        };
            return election.FirstOrDefault();
        }


        public List<int> GetAllPositionsElection(int electionId)
        {
            return db.Candidates
                .Where(c => c.ElectionId == electionId)
                .Select(c => c.PositionId)
                .Distinct()
                .ToList();
        }
        public void SetWinners(int electionId)
        {
            List<CandidatesDTO> list = GetCandidatesEachPosition(electionId);
            foreach (CandidatesDTO candidate in list)
            {
                db.Winners.Add(new Winner()
                {
                    ElectionId = electionId,
                    CandidateId = candidate.CandidateId,
                    Count = candidate.Count,
                    PositionId = candidate.PositionId
                });
                db.SaveChanges();
            }

        }
        public List<CandidatesDTO> GetCandidatesEachPosition(int electionId)
        {
            List<CandidatesDTO> list = new List<CandidatesDTO>();

            var positions = GetAllPositionsElection(electionId);

            foreach (var position in positions)
            {
                var groupedCandidates = db.VotedCandidates
                    .Where(vc => vc.ElectionId == electionId && vc.PositionId == position)
                    .GroupBy(vc => vc.CandidateId)
                    .Select(g => new CandidatesDTO
                    {
                        CandidateId = (int)g.Key,
                        Count = g.Count(),
                        PositionId = position
                    })
                    .ToList();

                if (groupedCandidates.Any())
                {
                    int maxVotes = groupedCandidates.Max(c => c.Count);
                    var topCandidates = groupedCandidates
                        .Where(c => c.Count == maxVotes)
                        .ToList();
                    list.AddRange(topCandidates);
                }
            }

            return list;
        }


    }
}