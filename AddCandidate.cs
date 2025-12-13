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
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace WindowsFormsApp1
{
    public partial class s : Form
    {
        private PositionService positionService = new PositionService();
        private CandidateService candidateService = new CandidateService();
        private string imagePath = string.Empty;
        private int departmentId;
        private ListBox formListBox;
        private string action;
        private int index;

        public s(int departmentId, string action, ListBox formListBox)
        {
            InitializeComponent();
            this.departmentId = departmentId;
            this.action = action;
            this.formListBox = formListBox;
            LoadPositions();

        }

        public s(Others editCandidate, int index, ListBox box, string action)
        {
            InitializeComponent();
            formListBox = box;
            candidate_name_box.Text = editCandidate.CandidateName;
            candidate_partylist_box.Text = editCandidate.Partylist;
            motto_box.Text = editCandidate.Motto;
            imagePath = editCandidate.Image;
            candidate_photo_picture.Image = Image.FromFile(imagePath);
            LoadPositions();
            candidate_positions_combo.SelectedItem = positionService.GetPositionName(editCandidate.PositionId);
            this.action = action;
            this.index = index;

        }


        public void LoadPositions()
        {
            try
            {
                List<string> positions = positionService.GetAllPositions();
                candidate_positions_combo.Items.Clear();

                foreach (var pos in positions)
                    candidate_positions_combo.Items.Add(pos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load positions.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            
        }

        private void add_candidate_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var cand in Others.othersList)
                {
                    if (cand.CandidateName.Equals(candidate_name_box.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Candidate already exists!");
                        return;
                    }
                }

                if (candidateService.DoesCandidateExist(candidate_name_box.Text))
                {
                    MessageBox.Show("Candidate already exists in another election!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(candidate_name_box.Text) ||
                    candidate_positions_combo.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(candidate_partylist_box.Text) ||
                    string.IsNullOrEmpty(imagePath))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                if (candidate_name_box.Text.Length > 100)
                {
                    MessageBox.Show("Candidate name is too long.");
                    return;
                }

                if (candidate_name_box.Text.Length < 3)
                {
                    MessageBox.Show("Candidate name is too short.");
                    return;
                }

                if (candidate_name_box.Text.Any(ch =>
                    !char.IsLetterOrDigit(ch) &&
                    !char.IsWhiteSpace(ch) &&
                    ch != '.' && ch != ',' && ch != '-' && ch != '\''))
                {
                    MessageBox.Show("Candidate name contains invalid characters.");
                    return;
                }
                if (action == "edit")
                {
                    Others.othersList[index].CandidateName = candidate_name_box.Text;
                    Others.othersList[index].Partylist = candidate_partylist_box.Text;
                    Others.othersList[index].Motto = motto_box.Text;
                    Others.othersList[index].Image = imagePath;
                    Others.othersList[index].PositionId =
                        positionService.GetPositionId(candidate_positions_combo.SelectedItem.ToString());

                    Others.LoadCandidates(formListBox);
                }
                else if (action == "add")
                {
                    AddCandidateTemporary();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void AddCandidateTemporary()
        {
            try
            {
                Others.othersList.Add(new Others
                {
                    CandidateName = candidate_name_box.Text,
                    Partylist = candidate_partylist_box.Text,
                    Motto = motto_box.Text,
                    Image = imagePath,
                    PositionId = positionService.GetPositionId(
                        candidate_positions_combo.SelectedItem.ToString()),
                    DepartmentId = departmentId
                });
                Others.LoadCandidates(formListBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to add candidate.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void candidate_photo_picture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    candidate_photo_picture.Image = Image.FromFile(openFileDialog.FileName);
                    imagePath = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load image.\n" + ex.Message,
                    "Image Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

    }
}
