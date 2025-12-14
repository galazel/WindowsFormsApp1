using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class VotedCandidatesService : DBConnection
    {
        public void AddVotedCandidates(int voterId, int candidateId, int electionId, int positionId)
        {
            using (var db = new eBotoDBEntities())
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
        }

        public Voter GetAllVotedCandidates(int voterId)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Voters.Include(v => v.VotedCandidates).FirstOrDefault(v => v.VoterId == voterId);
            }
        }

        public List<CandidatesDTO> GetCandidatesAndVotes(int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                var result = db.VotedCandidates
                    .Where(v => v.ElectionId == electionId)
                    .GroupBy(v => v.CandidateId)
                    .Select(g => new CandidatesDTO
                    {
                        CandidateId = (int)g.Key,
                        Count = g.Count()
                    })
                    .ToList();

                return result;
            }
        }

        public void ClearVotedCandidates(int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                var votedCandidates = db.VotedCandidates.Where(vc => vc.ElectionId == electionId).ToList();
                db.VotedCandidates.RemoveRange(votedCandidates);
                db.SaveChanges();
            }
        }

        public void ClearAllVotedCandidates()
        {
            using (var db = new eBotoDBEntities())
            {
                var allVotedCandidates = db.VotedCandidates.ToList();
                db.VotedCandidates.RemoveRange(allVotedCandidates);
                db.SaveChanges();
            }
        }

        public List<VotedCandidate> GetAllVotedCandidatesList()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.VotedCandidates.ToList();
            }
        }
        public int GetCandidateVoteCount(int candidateId, int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.VotedCandidates.Count(vc => vc.CandidateId == candidateId && vc.ElectionId == electionId);
            }
        }

    }
}
