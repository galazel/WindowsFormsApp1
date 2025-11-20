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
            DepartmentService departmentService = new DepartmentService();

                var elections =  db.Elections.Include(e => e.Candidates).Include(e => e.Department).Where(e => e.Status == false).ToList();

                foreach (var election in elections)
                {
                //ElectionDTO electionDTO = new ElectionDTO();
                //electionDTO.ElectionId = election.ElectionId;
                //electionDTO.ElectionName = election.ElectionName;
                //electionDTO.Department = election.Department.DepartmentName;
                //electionDTO.Status = election.Status;
                //electionDTO.Description = election.Description;
                //electionDTO.Candidates = election.Candidates.ToList();
                //list.Add(electionDTO);
                list.Add(GetElectionDepartmentPositions(election.ElectionId));
            }

            return list;
        }
        public List<ElectionDTO> GetOngoingElections()
        {
            var list = new List<ElectionDTO>();
            var elections = db.Elections.Include(e => e.Candidates).Include(e => e.Department).Where(e => e.Status == true && e.EndStatus == false).ToList();
            foreach (var election in elections)
            {
                //ElectionDTO electionDTO = new ElectionDTO();
                //electionDTO.ElectionId = election.ElectionId;
                //electionDTO.ElectionName = election.ElectionName;
                //electionDTO.Department = election.Department.DepartmentName;
                //electionDTO.Description = election.Description;
                //electionDTO.Candidates = election.Candidates.ToList();
                //electionDTO.Positions = GetElectionDepartmentPositions(election.ElectionId).Positions;
                
                list.Add(GetElectionDepartmentPositions(election.ElectionId));
            }

            return list;
        }

        public List<ElectionDTO> GetEndedElections()
        {
            var list = new List<ElectionDTO>();
            DepartmentService departmentService = new DepartmentService();
                var elections = db.Elections.Include(e => e.Candidates).Include(e => e.Department).Include(e => e.Winners).Where(e => e.EndStatus == true && e.Status == true).ToList();
                foreach (var election in elections)
                {
                //ElectionDTO electionDTO = new ElectionDTO();
                //electionDTO.ElectionId = election.ElectionId;
                //electionDTO.ElectionName = election.ElectionName;
                //electionDTO.Department = election.Department.DepartmentName;
                //electionDTO.Description = election.Description;
                //electionDTO.Candidates = election.Candidates.ToList();
                //electionDTO.Winners = election.Winners.ToList();

                //list.Add(electionDTO);
                list.Add(GetElectionDepartmentPositions(election.ElectionId));
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
            foreach (var position in GetAllPositionsElection(electionId))
            {
                var maxVotes = db.VotedCandidates
                    .Where(vc => vc.ElectionId == electionId && vc.PositionId == position)
                    .GroupBy(vc => vc.CandidateId)
                    .Select(g => new
                    {
                        Candidate = g.Key,
                        Count = g.Count()
                    })
                    .OrderByDescending(g => g.Count)
                    .FirstOrDefault();

                if (maxVotes != null)
                {
                    db.Winners.Add(new Winner()
                    {
                        ElectionId = electionId,
                        CandidateId = (int)maxVotes.Candidate,
                        Count = maxVotes.Count,
                        PositionId = position,
                    });

                    db.SaveChanges();
                }
            }
        }


    }
}