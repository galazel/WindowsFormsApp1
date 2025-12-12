using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class VotedCandidatesService : DBConnection
    {
        public void AddVotedCandidates(int voterId, int candidateId, int electionId, int positionId)
        {
                VotedCandidate votedCandidate = new VotedCandidate()
                {
                    VoterId = voterId,
                    CandidateId = candidateId,
                    ElectionId = electionId,
                    PositionId = positionId
                };
                db.VotedCandidates.Add(votedCandidate);
                db.SaveChanges();

        }
        public Voter GetAllVotedCandidates(int voterId)
        {
                return db.Voters.Include(v => v.VotedCandidates).FirstOrDefault(v => v.VoterId == voterId);   
        }

        public List<CandidatesDTO> GetCandidatesAndVotes(int electionId)
        {
                var result = db.VotedCandidates.Where(v => v.ElectionId == electionId).GroupBy(v => v.CandidateId).Select(g => new CandidatesDTO
                {
                    CandidateId = (int)g.Key,
                    Count = g.Count()
                })
                    .ToList();

                return result;
        }
        public void ClearVotedCandidates(int electionId)
        {
                var votedCandidates = db.VotedCandidates.Where(vc => vc.ElectionId == electionId).ToList();
                db.VotedCandidates.RemoveRange(votedCandidates);
                db.SaveChanges();
        }


    }
}
