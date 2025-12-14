using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WindowsFormsApp1
{
    internal class CandidateService 
    {
        private PositionService positionService;

        public CandidateService()
        {
            positionService = new PositionService();
        }

        public bool DoesCandidateExist(string candidateName)
        {
            using (var db = new eBotoDBEntities())
            {
                bool exists = db.Elections
                    .Include(e => e.Candidates)
                    .Any(e =>
                        !e.EndStatus &&                 
                        (e.Status || !e.Status) &&   
                        e.Candidates.Any(c => c.CandidateName == candidateName)
                    );
                if (exists)
                    return true;
            }
            return false;
        }

        public void AddCandidate(List<Others> candidates, int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                foreach (var candidate in candidates)
                {
                    Candidate newCandidate = new Candidate
                    {
                        CandidateName = candidate.CandidateName.ToUpper(),
                        Partylist = candidate.Partylist.ToUpper(),
                        Motto = candidate.Motto.ToUpper(),
                        PositionId = candidate.PositionId,
                        Image = candidate.Image,
                        DepartmentId = candidate.DepartmentId,
                        ElectionId = electionId
                    };
                    var existingCandidate = db.Candidates.FirstOrDefault(c => c.CandidateName == newCandidate.CandidateName && c.ElectionId == electionId);
                    if (existingCandidate != null)
                    {
                        db.Candidates.AddOrUpdate(newCandidate);
                    }
                    else
                    {
                        db.Candidates.Add(newCandidate);
                    }
                }
                db.SaveChanges();
            }
        }

        public void DeleteCandidateByNameAndElectionId(string candidateName, int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                var candidate = db.Candidates.FirstOrDefault(c => c.CandidateName == candidateName && c.ElectionId == electionId);
                if (candidate != null)
                {
                    db.Candidates.Remove(candidate);
                    db.SaveChanges();
                }
            }
        }

        public void UpdateCandidate(List<Others> candidateList, int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                var electionCandidates = db.Candidates.Where(c => c.ElectionId == electionId).ToList();
                db.Candidates.RemoveRange(electionCandidates);
                db.SaveChanges();

                foreach (var candidate in candidateList)
                {
                    Candidate updatedCandidate = new Candidate
                    {
                        CandidateName = candidate.CandidateName.ToUpper(),
                        Partylist = candidate.Partylist.ToUpper(),
                        Motto = candidate.Motto.ToUpper(),
                        PositionId = candidate.PositionId,
                        Image = candidate.Image,
                        DepartmentId = candidate.DepartmentId,
                        ElectionId = electionId
                    };
                    db.Candidates.Add(updatedCandidate);
                    db.SaveChanges();
                }
            }
        }

        public List<Candidate> GetCandidatesByElectionId(int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Candidates.Where(c => c.ElectionId == electionId).ToList();
            }
        }

        public void GetPositions(int electionId, int departmentId)
        {
            using (var db = new eBotoDBEntities())
            {
                var positions = db.Candidates
                                  .Where(c => c.ElectionId == electionId && c.DepartmentId == departmentId)
                                  .Select(c => c.PositionId)
                                  .Distinct()
                                  .ToList();

                Console.WriteLine(positions.Count());
                foreach (var po in positions)
                {
                    string positionName = positionService.GetPositionName(po);
                    Console.WriteLine("Position: " + positionName);
                }
            }
        }

        public int GetCandidateId(string candidateName, int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Candidates.FirstOrDefault(c => c.CandidateName == candidateName && c.ElectionId == electionId).CandidateId;
            }
        }

        public void DeleteCandidate(int candidateId)
        {
            using (var db = new eBotoDBEntities())
            {
                var candidate = db.Candidates.FirstOrDefault(c => c.CandidateId == candidateId);
                if (candidate != null)
                {
                    db.Candidates.Remove(candidate);
                    db.SaveChanges();
                }
            }
        }

        public Boolean IsPosition(int positionId, int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Candidates.Any(c => c.PositionId == positionId && c.ElectionId == electionId);
            }
        }

        public List<Candidate> GetCandidates(int positionId, int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Candidates.Where(ca => ca.PositionId == positionId && ca.ElectionId == electionId).ToList();
            }
        }

        public Candidate GetCandidate(int candidateId)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Candidates.FirstOrDefault(c => c.CandidateId == candidateId);
            }
        }

        public string GetCandidatesCount()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Candidates.Count().ToString();
            }
        }

        public string GetCandidateNameById(int id)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Candidates.FirstOrDefault(c => c.CandidateId == id).CandidateName;
            }
        }

        public string GetCandidatePartyById(int id)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Candidates.FirstOrDefault(c => c.CandidateId == id).Partylist;
            }
        }

        public string GetCandidateImage(int id)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Candidates.FirstOrDefault(c => c.CandidateId == id).Image;
            }
        }
    }
}
