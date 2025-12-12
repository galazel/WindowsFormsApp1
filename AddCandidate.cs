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
        private PositionService positionService;
        private string imagePath = string.Empty;
        private CandidateService candidateService;
        private int departmentId;
        private ListBox formListBox;
        private string action;
        private int index;

        public s(int departmentId, string action, ListBox formListBox)
        {
            InitializeComponent();
            candidateService = new CandidateService();
            positionService = new PositionService();
            this.departmentId = departmentId;
            this.action = action;
            this.formListBox = formListBox;
            LoadPositions();

        }

        public s(Others editCandidate, int index, ListBox box, string action)
        {
            InitializeComponent();
            candidateService = new CandidateService();
            positionService = new PositionService();
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
                if(action != null && action.Equals("edit"))
                { 
                    Others.othersList[index].CandidateName = candidate_name_box.Text;
                    Others.othersList[index].Partylist = candidate_partylist_box.Text;
                    Others.othersList[index].Motto = motto_box.Text;
                    Others.othersList[index].Image = imagePath;
                    Others.othersList[index].PositionId = positionService.GetPositionId(candidate_positions_combo.SelectedItem.ToString());
                    Others.LoadCandidates(formListBox);
                }
                else if(action != null && action.Equals("add"))
                    AddCandidateTemporary();
                this.Hide();
            }
        }

        public void AddCandidateTemporary()
        {
            Others.othersList.Add(new Others
            {
                CandidateName = candidate_name_box.Text,
                Partylist = candidate_partylist_box.Text,
                Motto = motto_box.Text,
                Image = imagePath,
                PositionId = positionService.GetPositionId(candidate_positions_combo.SelectedItem.ToString()),
                DepartmentId = departmentId
            });
            Others.LoadCandidates(formListBox);
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
