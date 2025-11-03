using System;
using System.CodeDom;
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
    public partial class s : Form
    {
        private PositionService positionService;
        private string imagePath = string.Empty;
        private CandidateService candidateService;
        private int departmentId;
        public s(int departmentId)
        {
            InitializeComponent();
            candidateService = new CandidateService();
            positionService = new PositionService();
            this.departmentId = departmentId;
            LoadPositions();

        }
        public void LoadPositions()
        {
            List<string> positions = positionService.GetAllPositions();
            candidate_positions_combo.Items.Clear();
            foreach (var pos in positions)
            {
                candidate_positions_combo.Items.Add(pos);
            }
        }

        private void add_candidate_bttn_Click(object sender, EventArgs e)
        {
            if (candidateService.DoesCandidateExist(candidate_name_box.Text))
            {
                MessageBox.Show("Candidate already exists!");
                return;
            }
            else if (candidate_name_box.Text.Equals("") || candidate_positions_combo.SelectedItem == null || candidate_partylist_box.Text.Equals("") || string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }else
            {
                candidateService.AddCandidate(candidate_name_box.Text,candidate_partylist_box.Text,motto_box.Text,candidate_positions_combo.SelectedItem.ToString(),imagePath,departmentId);
                this.Hide();
            }
        }

        private void candidate_photo_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                candidate_photo_picture.Image = Image.FromFile(openFileDialog.FileName);
                imagePath = openFileDialog.FileName;
            }
        }
    }
}
