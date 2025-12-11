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
        public static ListBox candidateList;

        private int electionId;
        private int departmentId;
        public UpdateElection(FlowLayoutPanel layout, int electionId, int departmentId)
        {
            InitializeComponent();
            this.electionsPanel = layout;
            this.electionId= electionId;
            this.departmentId = departmentId;
            candidateList = candidates_list;
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
            foreach (var candidate in candidateService.GetCandidatesByElectionId(electionId))
                candidates_list.Items.Add(candidate.CandidateName.ToUpper() + " <----------> " + positionService.GetPositionName(candidate.PositionId));
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
            else if (e.KeyCode == Keys.E)
            {
                if (candidates_list.SelectedItem == null)
                    return;
                int index = candidates_list.SelectedIndex;
                MessageBox.Show(index.ToString());
                var selectedCandidate = Others.othersList[index];
                new s(selectedCandidate, index, candidateList, "edit").ShowDialog();

            }
        }
        private void update_election_bttn_Click(object sender, EventArgs e)
        {
            if (election_name_box.Text.Equals("") || description_box.Text.Equals("") || departments_combo.SelectedItem == null || candidates_list.Items.Count == 0)
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                electionService.EditElection(electionId,election_name_box.Text, description_box.Text, departmentService.GetDepartmentIdByName(departments_combo.SelectedItem.ToString()));
                candidateService.AddCandidate(Others.othersList, electionService.GetElectionId(election_name_box.Text));
                MessageBox.Show("Election Added Successfully!");
                Others.othersList.Clear();
                Others.LoadElections(electionsPanel);
                this.Hide();

            }
        }

        private void add_candidate_bttn_Click(object sender, EventArgs e)
        {
            new s(departmentService.GetDepartmentIdByName(departments_combo.SelectedItem.ToString()), "add", candidateList).ShowDialog();
        }
    }
}
