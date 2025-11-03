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
    public partial class CreateElection : Form
    {
        private DepartmentService departmentService;
        private ElectionService electionService;
        private CandidateService candidateService;
        public CreateElection()
        {
            InitializeComponent();
            departmentService = new DepartmentService();
            electionService = new ElectionService();
            candidateService = new CandidateService();
            LoadDepartments();
        }
        public void LoadDepartments()
        {
            List<string> departments = departmentService.GetAllDepartments();
            departments_combo.Items.Clear();
            foreach (var dept in departments)
            {
                departments_combo.Items.Add(dept);
            }
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
            }else
            {
                MessageBox.Show("Election Added Successfully!");
                candidateService.AddCandidate(electionService.GetElectionId(election_name_box.Text));
            }
        }




    }
}
