using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WinnerPanel : UserControl
    {
        private CandidateService candidateService;
        private PositionService positionService;

        public WinnerPanel(Winner winner)
        {
            InitializeComponent();

            try
            {
                if (winner == null)
                    throw new ArgumentNullException(nameof(winner), "Winner data is missing.");

                candidateService = new CandidateService();
                positionService = new PositionService();

                string candidateName = candidateService.GetCandidateNameById(winner.CandidateId) ?? "Unknown";
                string positionName = positionService.GetPositionName(winner.PositionId) ?? "Unknown";
                string partyName = candidateService.GetCandidatePartyById(winner.CandidateId) ?? "Unknown";
                string voteCount = winner.Count.ToString();
                string imagePath = candidateService.GetCandidateImage(winner.CandidateId);

                name.Text = $"Name: {candidateName}";
                position.Text = $"Position: {positionName}";
                party.Text = $"Party: {partyName}";
                votes.Text = $"Votes: {voteCount}";

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    candidate_image.Image = Image.FromFile(imagePath);
                else
                    candidate_image.Image = Properties.Resources.default_candidate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load winner panel.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
