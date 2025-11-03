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
        public void AddCandidate(List<Others> candidates, int electionId)
        {
            using(var db = new eBotoDBEntities())
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
        }

    }
}
