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
    public partial class WinnerPanel : UserControl
    {
        private CandidateService candidateService;
        private PositionService positionService;
        public WinnerPanel(Winner winner)
        {
            InitializeComponent();
            candidateService = new CandidateService();
            positionService = new PositionService();

            string n = candidateService.GetCandidateNameById(winner.CandidateId);
            string po = positionService.GetPositionName(winner.PositionId);
            string pa = candidateService.GetCandidatePartyById(winner.CandidateId);
            string v = Convert.ToString(winner.Count);
            string image = candidateService.GetCandidateImage(winner.CandidateId);


            name.Text = $"Name: {n}";
            position.Text = $"Position: {po}";
            party.Text = $"Party: {pa}";
            votes.Text = $"Votes: {v}";
            candidate_image.Image = Image.FromFile(image);
        }
    }
}
