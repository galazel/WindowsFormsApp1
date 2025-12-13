using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowsFormsApp1.DTOs;

namespace WindowsFormsApp1
{
    public class ElectionService : DBConnection
    {
        public int GetElectionId(string electionName)
        {
            using (var db = new eBotoDBEntities())
            {
                var election = db.Elections.FirstOrDefault(e => e.ElectionName == electionName);
                return election != null ? election.ElectionId : -1;
            }
        }
        public bool DoesElectionStillOngoing()
        {
            using (var db = new eBotoDBEntities())
            {
                var election = db.Elections.FirstOrDefault(e => (e.Status && !e.EndStatus) || (e.Status && e.EndStatus));
                if(election != null)
                    return true;
                else
                    return false;
            }
        }
        public void AddElection(string electionName, string description, bool isActive, int departmentId)
        {
            using (var db = new eBotoDBEntities())
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
        }

        public void EditElection(int electionId, string electionName, string description, int departmentId)
        {
            using (var db = new eBotoDBEntities())
            {
                var election = db.Elections.FirstOrDefault(e => e.ElectionId == electionId);
                if (election != null)
                {
                    election.ElectionName = electionName;
                    election.Description = description;
                    election.DepartmentId = departmentId;
                    db.SaveChanges();
                }
            }
        }

        public List<ElectionDTO> GetElections()
        {
            using (var db = new eBotoDBEntities())
            {
                var list = new List<ElectionDTO>();
                var elections = db.Elections.Include(e => e.Candidates).Include(e => e.Department).Where(e => e.Status == false).ToList();

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
        }

        public Election GetElection(int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Elections.FirstOrDefault(e => e.ElectionId == electionId);
            }
        }

        public List<ElectionDTO> GetOngoingElections()
        {
            using (var db = new eBotoDBEntities())
            {
                var list = new List<ElectionDTO>();
                var elections = db.Elections.Include(e => e.Candidates).Include(e => e.Department).Where(e => e.Status == true && e.EndStatus == false).ToList();
                foreach (var election in elections)
                    list.Add(GetElectionDepartmentPositions(election.ElectionId));
                return list;
            }
        }

        public List<ElectionDTO> GetEndedElections()
        {
            using (var db = new eBotoDBEntities())
            {
                var list = new List<ElectionDTO>();
                var elections = db.Elections.Include(e => e.Candidates).Include(e => e.Department).Include(e => e.Winners).Where(e => e.EndStatus == true && e.Status == true).ToList();

                foreach (var election in elections)
                {
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
        }

        public void ClearEndedElections()
        {
            using (var db = new eBotoDBEntities())
            {
                var endedElections = db.Elections.Where(e => e.EndStatus == true).ToList();
                foreach (var election in endedElections)
                {
                    db.Candidates.RemoveRange(db.Candidates.Where(c => c.ElectionId == election.ElectionId));
                    db.VotedCandidates.RemoveRange(db.VotedCandidates.Where(vc => vc.ElectionId == election.ElectionId));
                    db.Winners.RemoveRange(db.Winners.Where(w => w.ElectionId == election.ElectionId));
                }
                db.Elections.RemoveRange(endedElections);
                db.SaveChanges();
            }
        }

        public bool DoesElectionInDepartmentStillOngoing(int departmentId)
        {
            using (var db = new eBotoDBEntities())
            {
                var election = db.Elections.FirstOrDefault(e => e.DepartmentId == departmentId && e.Status && !e.EndStatus);
                return election != null;
            }
        }

        public Boolean DoesElectionAlreadyExisted(string electionName)
        {
            using (var db = new eBotoDBEntities())
            {
                var election = db.Elections.FirstOrDefault(e => e.ElectionName == electionName);
                return election != null;
            }
        }

        public void UpdateElectionStatus(int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                var election = db.Elections.FirstOrDefault(e => e.ElectionId == electionId);
                if (election != null)
                {
                    election.Status = true;
                    db.SaveChanges();
                }
            }
        }

        public void SetElectionInactive(int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                var election = db.Elections.FirstOrDefault(e => e.ElectionId == electionId);
                if (election != null)
                {
                    election.Status = false;
                    db.SaveChanges();
                }
            }
        }

        public List<Election> GetActiveElections()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Elections.Where(e => e.Status == true).ToList();
            }
        }

        public List<Election> GetInactiveElections()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Elections.Where(e => e.Status == false).ToList();
            }
        }

        public void DeleteElection(int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                db.Elections.RemoveRange(db.Elections.Where(e => e.ElectionId == electionId));
                db.Candidates.RemoveRange(db.Candidates.Where(c => c.ElectionId == electionId));
                db.SaveChanges();
            }
        }

        public bool FindDepartmentActiveElection(int departmentId)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Elections.Any(e => e.DepartmentId == departmentId && e.Status == true && e.EndStatus == false);
            }
        }

        public string GetElectionsCount()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Elections.Count().ToString();
            }
        }

        public void SetEndStatus(int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                var election = db.Elections.FirstOrDefault(e => e.ElectionId == electionId);
                if (election != null)
                {
                    election.EndStatus = true;
                    db.SaveChanges();
                }
            }
        }

        public ElectionDTO GetElectionDepartmentPositions(int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                var election = from v in db.Elections
                               join d in db.Departments on v.DepartmentId equals d.DepartmentId
                               join c in db.Candidates on v.ElectionId equals c.ElectionId
                               where v.ElectionId == electionId
                               select new ElectionDTO
                               {
                                   Department = d,
                                   Election = v,
                                   Candidates = v.Candidates.ToList(),
                                   Positions = v.Candidates.Where(ca => ca.ElectionId == v.ElectionId).Select(ca => ca.Position).Distinct().ToList()
                               };
                return election.FirstOrDefault();
            }
        }

        public List<int> GetAllPositionsElection(int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Candidates
                    .Where(c => c.ElectionId == electionId)
                    .Select(c => c.PositionId)
                    .Distinct()
                    .ToList();
            }
        }

        public void SetWinners(int electionId)
        {
            using (var db = new eBotoDBEntities())
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
        }

        public List<CandidatesDTO> GetCandidatesEachPosition(int electionId)
        {
            using (var db = new eBotoDBEntities())
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

        public void SetElectionsOnList(int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                Others.othersList.Clear();
                Others.othersList = db.Candidates
                    .Where(c => c.ElectionId == electionId)
                    .Select(c => new Others
                    {
                        CandidateName = c.CandidateName,
                        Partylist = c.Partylist,
                        Motto = c.Motto,
                        Image = c.Image,
                        PositionId = c.PositionId,
                        DepartmentId = c.Election.DepartmentId
                    })
                    .ToList();
            }
        }
    }
}
