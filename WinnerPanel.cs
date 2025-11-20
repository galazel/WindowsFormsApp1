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

            string n = candidateService.GetCandidateNameById(winner.CandidateId);
            string po = positionService.GetPositionName(winner.PositionId);
            string pa = candidateService.GetCandidatePartyById(winner.CandidateId);
            string v = Convert.ToString(winner.Count);
            string image = candidateService.GetCandidateImage(winner.CandidateId);


            name.Text = n;
            position.Text = po;
            party.Text = pa;
            votes.Text = v;
            candidate_image.Image = Image.FromFile(image);
        }
    }
}
