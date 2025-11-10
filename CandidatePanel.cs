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
    public partial class CandidatePanel : UserControl
    {
        private string positionName;
        private Candidate candidate;
        public event Action OnUpdateRequested;
        public CandidatePanel(Candidate candidate, string positionName)
        {
            InitializeComponent();
            candidate_image.Image = Image.FromFile(candidate.Image);
            candidate_name_label.Text = $"NAME: {candidate.CandidateName.ToUpper()}";
            candidate_party_label.Text = $"PARTY: {candidate.Partylist}";
            this.positionName = positionName;
            this.candidate = candidate;
        }

        private void vote_candidate_bttn_Click(object sender, EventArgs e)
        {
            if (ElectionSummary.ChoosenCandidates.ContainsKey(positionName))
                ElectionSummary.ChoosenCandidates[positionName] = candidate;
            OnUpdateRequested?.Invoke();
        }
    }
}
