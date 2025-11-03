using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class CandidateService
    {
        private PositionService positionService;
        public CandidateService()
        {
            positionService = new PositionService();
        }
        public Boolean DoesCandidateExist(string candidateName)
        {
            using(var db = new eBotoDBEntities())
            {
                return db.Candidates.Any(c => c.CandidateName == candidateName);
            }
        }
        public void AddCandidate(string name, string partylist,string motto, string position, string image, int departmentId)
        {
            int positionId = positionService.GetPositionId(position);
            using(var db = new eBotoDBEntities())
            {
                Candidate newCandidate = new Candidate
                {
                    CandidateName = name,
                    Partylist = partylist,
                    Motto = "",
                    PositionId = positionId,
                    Image = image,
                    DepartmentId = 1,
                    ElectionId = 1
                };
                db.Candidates.Add(newCandidate);
                db.SaveChanges();
            }
        }
        public void AddCandidate(int electionId)
        {
            using(var db = new eBotoDBEntities())
            {
                var candidatesInElection = db.Candidates.Where(c => c.ElectionId == electionId).ToList();
                foreach(var candidate in candidatesInElection)
                    candidate.ElectionId = electionId;
            }
        }

    }
}
