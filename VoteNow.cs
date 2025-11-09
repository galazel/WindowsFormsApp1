using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VoteNow : Form
    {
        private List<Position> positions;
        private int electionId, voterId;
        public event Action OnUpdateRequested;
        private VoterDTO voterDTO;

        public VoteNow(List<Position> positions, int electionId, int voterId, VoterDTO voterDto)
        {
            InitializeComponent();
            this.positions = positions;
            this.electionId = electionId;
            this.voterId = voterId;
            this.voterDTO = voterDto;
            AddFlowEachPosition();
        }
        public void AddFlowEachPosition()
        {
            ElectionSummary.ChoosenCandidates.Clear();
            foreach (var position in positions)
            {
                int positionId = position.PositionId;
                string positionName = position.PositionName;
                ElectionSummary.ChoosenCandidates.Add(positionName, null);
                if (new CandidateService().IsPosition(positionId, electionId))
                {
                    List <Candidate> candidates = new CandidateService().GetCandidate(positionId, electionId);
                    PositionFlowLayout positionFlowLayout = new PositionFlowLayout(positionName);

                    foreach (Candidate candidate in candidates)
                        positionFlowLayout.AddPositionPanel(new CandidatePanel(candidate,positionName));    
                    
                    vote_candidates_flow.Controls.Add(positionFlowLayout);

                }
            }
            Console.WriteLine(ElectionSummary.ChoosenCandidates.Count());
        }

        private void vote_candidate_bttn_Click(object sender, EventArgs e)
        {
            StringBuilder summary = new StringBuilder();
            foreach(var item in ElectionSummary.ChoosenCandidates)
                summary.AppendLine($"{item.Key} - {item.Value.CandidateName}");
            MessageBox.Show("Summary: \n"+summary);
            new VoterService().SetVoterStatus(voterId);
            voterDTO.Voter.Status = true;

            foreach(var candidate in ElectionSummary.ChoosenCandidates)
                new VotedCandidatesService().AddVotedCandidates(voterId, candidate.Value.CandidateId, electionId);
            MessageBox.Show("Thank you for voting!");
            OnUpdateRequested?.Invoke();
            this.Hide();
        }

    
    }
}
