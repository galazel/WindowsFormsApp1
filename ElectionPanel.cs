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
    public partial class ElectionPanel : UserControl
    {
        private List<Candidate> candidates;
        private string description;
        private bool status;
        private int id;
        private ElectionService electionService;
        public ElectionPanel(ElectionDTO electionDto)
        {
            InitializeComponent();
            electionService = new ElectionService();
            election_name_label.Text = electionDto.ElectionName;
            department_label.Text = electionDto.Department;
            this.status = electionDto.Status;
            this.id = electionDto.ElectionId;
            this.candidates = electionDto.Candidates;
            this.description = electionDto.Description;
        }


        private void start_bttn_Click(object sender, EventArgs e)
        {
            status = !status;
            electionService.UpdateElectionStatus(id);
            MessageBox.Show("Election status updated successfully!");
        }

        private void view_details_bttn_Click_1(object sender, EventArgs e)
        {
            StringBuilder candidatesString = new StringBuilder();
            PositionService positionService = new PositionService();

            foreach (Candidate candidate in candidates)
            {
                candidatesString.AppendLine(candidate.CandidateName + "----------" + positionService.GetPositionName(candidate.PositionId));
            }
            MessageBox.Show($"Election Name: {election_name_label.Text}\nDepartment: {department_label.Text}\nDescription: {description}\nCandidates: \n" + candidatesString);
        }

        private void delete_bttn_Click(object sender, EventArgs e)
        {

        }
    }
}
