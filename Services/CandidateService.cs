using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsFormsApp1
{
    internal class CandidateService : DBConnection
    {
        private PositionService positionService;
        public CandidateService()
        {
            positionService = new PositionService();
        }
        public Boolean DoesCandidateExist(string candidateName)
        {
           return db.Candidates.Any(c => c.CandidateName == candidateName);
        }
        public void AddCandidate(List<Others> candidates, int electionId)
        {
           foreach(var candidate in candidates)
           {
               Candidate newCandidate = new Candidate
               {
                   CandidateName = candidate.CandidateName,
                   Partylist = candidate.Partylist,
                   Motto = candidate.Motto,
                   PositionId = candidate.PositionId,
                   Image = candidate.Image,
                   DepartmentId = candidate.DepartmentId,
                   ElectionId = electionId
                   };
                    db.Candidates.Add(newCandidate);
               }
               db.SaveChanges();
        }
        public void UpdateCandidate(int electionId)
        {
            var candidates = db.Candidates.Where(c => c.ElectionId == electionId).ToList();
            if(candidates.Count != 0)
               db.Candidates.RemoveRange(candidates);

            db.SaveChanges();
        }

        public List<Candidate> GetCandidatesByElectionId(int electionId)
        {
           return db.Candidates.Where(c => c.ElectionId ==  electionId).ToList();
        }
        public void GetPositions(int electionId, int departmentId)
        {
                var positions = db.Candidates.Where(c => c.ElectionId == electionId && c.DepartmentId == departmentId).Select(c => c.PositionId).Distinct().ToList();
                Console.WriteLine(positions.Count());
                foreach(var po in positions)
                {
                    string positionName = positionService.GetPositionName(po);
                    Console.WriteLine("Position: " + positionName);
                }
        }

        public Boolean IsPosition(int positionId, int electionId)
        {
            return db.Candidates.Any(c => c.PositionId == positionId && c.ElectionId == electionId);
        }

        public List<Candidate> GetCandidates(int positionId, int electionId)
        {
           return db.Candidates.Where(ca => ca.PositionId == positionId && ca.ElectionId == electionId).ToList();
        }

        public Candidate GetCandidate(int candidateId)
        {
           return db.Candidates.FirstOrDefault(c => c.CandidateId == candidateId);
        }
        public string GetCandidatesCount()
        {
           return db.Candidates.Count().ToString();
        }
        public string GetCandidateNameById(int id)
        {
            return db.Candidates.FirstOrDefault(c => c.CandidateId == id).CandidateName;
        }
        public string GetCandidatePartyById(int id)
        {
            return db.Candidates.FirstOrDefault(c => c.CandidateId == id).Partylist;
        }

        public string GetCandidateImage(int id)
        {
            return db.Candidates.FirstOrDefault(c => c.CandidateId == id).Image;
        }


    }
}
