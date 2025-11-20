using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CreateElection : Form
    {
        private DepartmentService departmentService;
        private ElectionService electionService;
        private CandidateService candidateService;
        private PositionService positionService;
        public static ListBox candidateList;
        private FlowLayoutPanel electionsPanel;
        public CreateElection(FlowLayoutPanel electionsPanel)
        {
            InitializeComponent();
            this.electionsPanel = electionsPanel;
            departmentService = new DepartmentService();
            electionService = new ElectionService();
            candidateService = new CandidateService();
            candidateList = candidates_list;
            positionService = new PositionService();
            LoadDepartments();
        }
        public void LoadDepartments()
        {
            List<string> departments = departmentService.GetAllDepartments();
            departments_combo.Items.Clear();
            foreach (var dept in departments)
                departments_combo.Items.Add(dept);
        }

        private void add_candidate_bttn_Click(object sender, EventArgs e)
        {
            new s(departmentService.GetDepartmentIdByName(departments_combo.SelectedItem.ToString())).ShowDialog();
        }

        private void add_election_bttn_Click(object sender, EventArgs e)
        {
            
            if (election_name_box.Text.Equals("") || description_box.Text.Equals("") || departments_combo.SelectedItem == null || candidates_list.Items.Count == 0)
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else if (electionService.DoesElectionAlreadyExisted(election_name_box.Text, departmentService.GetDepartmentIdByName(departments_combo.SelectedItem.ToString())))
            {
                MessageBox.Show("An election already exists in the selected department.");
                return;
            }else
            {
                electionService.AddElection(election_name_box.Text, description_box.Text, false, departmentService.GetDepartmentIdByName(departments_combo.SelectedItem.ToString()));
                candidateService.AddCandidate(Others.othersList, electionService.GetElectionId(election_name_box.Text));
                MessageBox.Show("Election Added Successfully!");
                this.Hide();
                Others.othersList.Clear();
                Others.LoadElections(electionsPanel);

            }
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
        public void LoadCandidates()
        {
            candidateList.Items.Clear();
            foreach (var candidate in Others.othersList)
                candidateList.Items.Add(candidate.CandidateName.ToUpper() + " ===================>" + positionService.GetPositionName(candidate.PositionId));
        }
    }
}
