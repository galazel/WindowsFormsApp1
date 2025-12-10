using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UpdateElection : Form
    {
        private ElectionService electionService = new ElectionService();
        private DepartmentService departmentService = new DepartmentService();
        private CandidateService candidateService = new CandidateService();
        private PositionService positionService = new PositionService();
        private FlowLayoutPanel electionsPanel;

        private int electionId;
        public UpdateElection(FlowLayoutPanel layout, int electionId)
        {
            InitializeComponent();
            this.electionsPanel = layout;
            this.electionId= electionId;
            LoadDepartments();
            LoadContents();
        }
        public void LoadContents()
        {
            var election = electionService.GetElection(electionId);
            var candidadates = candidateService.GetCandidatesByElectionId(electionId);
            if (election != null)
            {
                election_name_box.Text = election.ElectionName;
                description_box.Text = election.Description;
                departments_combo.SelectedItem = departmentService.GetDepartmentNameById(election.DepartmentId);

                foreach(var candidate in candidadates)
                    candidates_list.Items.Add(candidate.CandidateName.ToUpper() + " <----------> " + positionService.GetPositionName(candidate.PositionId));
            }
        }
        public void LoadCandidates()
        {
            candidates_list.Items.Clear();
            foreach (var candidate in Others.othersList)
            {
                candidates_list.Items.Add(candidate.CandidateName.ToUpper() + " <----------> " + positionService.GetPositionName(candidate.PositionId));
            }
        }
        public void LoadDepartments()
        {
            List<string> departments = departmentService.GetAllDepartments();
            departments_combo.Items.Clear();
            foreach (var dept in departments)
                departments_combo.Items.Add(dept);
        }
        private void candidates_list_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (candidates_list.SelectedItem == null)
                    return;

                var confirm = MessageBox.Show("Do you want to delete this record?",
                                              "Confirm Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    Others.othersList.RemoveAt(candidates_list.SelectedIndex);
                    LoadCandidates();
                }

            }
        }

        private void update_election_bttn_Click(object sender, EventArgs e)
        {
            if (election_name_box.Text.Equals("") || description_box.Text.Equals("") || departments_combo.SelectedItem == null || candidates_list.Items.Count == 0)
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else if (electionService.DoesElectionAlreadyExisted(election_name_box.Text, departmentService.GetDepartmentIdByName(departments_combo.SelectedItem.ToString())))
            {
                MessageBox.Show("An election already exists in the selected department.");
                return;
            }
            else if (candidates_list.Items.Count < 5 && departments_combo.Items.Count > 1)
            {
                MessageBox.Show("Please add at least five candidate.");
                return;
            }
            else
            {
                electionService.EditElection(Others.FlowState ? electionService.GetElectionId(Others.othersList[0].CandidateName) : electionService.GetElectionId(election_name_box.Text), election_name_box.Text, description_box.Text, departmentService.GetDepartmentIdByName(departments_combo.SelectedItem.ToString()));
                candidateService.UpdateCandidate(electionService.GetElectionId(election_name_box.Text));
                MessageBox.Show("Election Updated Successfully!");
                Others.othersList.Clear();
                Others.LoadElections(electionsPanel);
                this.Hide();

            }
        }
    }
}
