using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VoteNow : Form
    {
        private readonly List<Position> positions;
        private readonly int electionId;
        private readonly int voterId;

        private readonly CandidateService candidateService = new CandidateService();
        private readonly VoterService voterService = new VoterService();
        private readonly VotedCandidatesService votedCandidatesService = new VotedCandidatesService();

        public event Action OnUpdateRequested;
        private readonly VoterDTO voterDTO;

        public VoteNow(List<Position> positions, int electionId, int voterId, VoterDTO voterDto)
        {
            InitializeComponent();

            this.positions = positions;
            this.electionId = electionId;
            this.voterId = voterId;
            this.voterDTO = voterDto;

            try
            {
                AddFlowEachPosition();
                SetSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load voting data.\n" + ex.Message);
            }
        }

        public void SetSummary()
        {
            try
            {
                chosen_flow.Controls.Clear();

                foreach (var chosen in ElectionSummary.ChoosenCandidates)
                {
                    if (chosen.Value == null)
                        chosen_flow.Controls.Add(new SummaryPanel("", chosen.Key));
                    else
                        chosen_flow.Controls.Add(
                            new SummaryPanel(chosen.Value.CandidateName, chosen.Key)
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating summary.\n" + ex.Message);
            }
        }

        public void AddFlowEachPosition()
        {
            try
            {
                ElectionSummary.ChoosenCandidates.Clear();
                vote_candidates_flow.Controls.Clear();

                foreach (var position in positions)
                {
                    int positionId = position.PositionId;
                    string positionName = position.PositionName;

                    ElectionSummary.ChoosenCandidates.Add(positionName, null);

                    if (!candidateService.IsPosition(positionId, electionId))
                        continue;

                    List<Candidate> candidates =
                        candidateService.GetCandidates(positionId, electionId);

                    if (candidates == null || candidates.Count == 0)
                        continue;

                    PositionFlowLayout positionFlowLayout =
                        new PositionFlowLayout(positionName);

                    foreach (Candidate candidate in candidates)
                    {
                        CandidatePanel candidatePanel =
                            new CandidatePanel(candidate, positionName);

                        candidatePanel.OnUpdateRequested += SetSummary;
                        positionFlowLayout.AddPositionPanel(candidatePanel);
                    }

                    vote_candidates_flow.Controls.Add(positionFlowLayout);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading candidates.\n" + ex.Message);
            }
        }

        private void vote_candidate_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var chosen in ElectionSummary.ChoosenCandidates)
                {
                    if (chosen.Value == null)
                    {
                        MessageBox.Show("Please choose a candidate for all positions.");
                        return;
                    }
                }

                StringBuilder summary = new StringBuilder();
                foreach (var item in ElectionSummary.ChoosenCandidates)
                {
                    summary.AppendLine($"{item.Key} - {item.Value.CandidateName}");
                }

                MessageBox.Show("Summary:\n" + summary);

                voterService.SetVoterStatus(voterId);
                voterDTO.Voter.Status = true;

                foreach (var candidate in ElectionSummary.ChoosenCandidates.Values)
                {
                    votedCandidatesService.AddVotedCandidates(
                        voterId,
                        candidate.CandidateId,
                        electionId,
                        candidate.PositionId
                    );
                }

                MessageBox.Show("Thank you for voting!");
                OnUpdateRequested?.Invoke();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Voting failed.\n" + ex.Message);
            }
        }
    }
}
