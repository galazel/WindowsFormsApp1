using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class VotedCandidatesService
    {
        public void AddVotedCandidates(int voterId, int candidateId)
        {
            using(var db = new eBotoDBEntities())
            {
                VotedCandidate votedCandidate = new VotedCandidate()
                {
                    VoterId = voterId,
                    CandidateId = candidateId
                };
                db.VotedCandidates.Add(votedCandidate);
                db.SaveChanges();
            }

        }
    }
}
