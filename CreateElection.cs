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
        private string action;
        private ElectionDTO election;
  
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
        public CreateElection(FlowLayoutPanel electionsPanel, ElectionDTO election, string action)
        {
            InitializeComponent();
            this.electionsPanel = electionsPanel;
            departmentService = new DepartmentService();
            electionService = new ElectionService();
            candidateService = new CandidateService();
            candidateList = candidates_list;
            positionService = new PositionService();
            this.action = action;
            this.election = election;
            election_name_box.Text = election.Election.ElectionName;
            description_box.Text = election.Election.Description;
            LoadDepartments();
            departments_combo.SelectedItem = departmentService.GetDepartmentNameById(election.Department.DepartmentId);
            electionService.SetElectionsOnList(election.Election.ElectionId);
            LoadCandidates();
           
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
            if (departments_combo.SelectedItem == null)
            {
                MessageBox.Show("Please select the valid department first before adding candidates.");
                return;
            }
            new s(departmentService.GetDepartmentIdByName(departments_combo.SelectedItem.ToString()), "add", candidateList).ShowDialog(); 

        }

        private void add_election_bttn_Click(object sender, EventArgs e)
        {

            if (election_name_box.Text.Equals("") || description_box.Text.Equals("") || departments_combo.SelectedItem == null || candidates_list.Items.Count == 0)
            {
                MessageBox.Show("Please fill in all required fields.");
            }else if(electionService.DoesElectionAlreadyExisted(election_name_box.Text) && action == null)
            {
                MessageBox.Show("An Election with that name already exists!");
            }else if(departments_combo.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid department.");
                return;
            }
            else
            {
                if (action != null && action.Equals("edit"))
                {
                    electionService.EditElection(election.Election.ElectionId, election_name_box.Text, description_box.Text, departmentService.GetDepartmentIdByName(departments_combo.SelectedItem.ToString()));
                    candidateService.UpdateCandidate(Others.othersList, election.Election.ElectionId);
                    MessageBox.Show("Election Updated Successfully!");
                    Others.othersList.Clear();
                    Others.LoadElections(electionsPanel);
                    this.Hide();

                }
                else
                {
                    electionService.AddElection(election_name_box.Text, description_box.Text, false, departmentService.GetDepartmentIdByName(departments_combo.SelectedItem.ToString()));
                    candidateService.AddCandidate(Others.othersList, electionService.GetElectionId(election_name_box.Text));
                    MessageBox.Show("Election Added Successfully!");
                    Others.othersList.Clear();
                    Others.LoadElections(electionsPanel);
                    this.Hide();
                }
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
                    if(action != null && action.Equals("edit"))
                    {
                        Others.othersList.RemoveAt(candidates_list.SelectedIndex);
                        candidateService.UpdateCandidate(Others.othersList, election.Election.ElectionId);
                        LoadCandidates();
                    }
                    else
                    {
                        Others.othersList.RemoveAt(candidates_list.SelectedIndex);
                        LoadCandidates();
                    }
                        
                }
                   
            }else if(e.KeyCode == Keys.E)
            {
                if (candidates_list.SelectedItem == null)
                    return;
                int index = candidates_list.SelectedIndex;
                var selectedCandidate = Others.othersList[index];
                new s(selectedCandidate,index, candidateList, "edit").ShowDialog();

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
