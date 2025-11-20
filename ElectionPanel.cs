using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ElectionPanel : UserControl
    {
        private List<Candidate> candidates;
        private ElectionService electionService;
        private ElectionDTO election;
        public event Action OnUpdateRequested;

        public ElectionPanel(ElectionDTO electionDto)
        {
            InitializeComponent();
            electionService = new ElectionService();
            this.election = electionDto;
            election_name_label.Text = electionDto.Election.ElectionName;
            department_label.Text = electionDto.Department.DepartmentName;
            this.candidates = electionDto.Candidates;
        }

        public ElectionPanel()
        {
            InitializeComponent();
        }

        private void start_bttn_Click(object sender, EventArgs e)
        {
            election.Election.Status = !election.Election.Status;
            electionService.UpdateElectionStatus(election.Election.ElectionId);
            MessageBox.Show("Election status updated successfully!");
            OnUpdateRequested?.Invoke();
        }

        private void view_details_bttn_Click_1(object sender, EventArgs e)
        {
            StringBuilder candidatesString = new StringBuilder();
            PositionService positionService = new PositionService();

            foreach (Candidate candidate in candidates)
            {
                candidatesString.AppendLine(
                    $"{candidate.CandidateName} ---------- {positionService.GetPositionName(candidate.PositionId)}"
                );
            }

            MessageBox.Show(
                $"Election Name: {election_name_label.Text}\n" +
                $"Department: {department_label.Text}\n" +
                $"Description: {election.Election.Description}\n" +
                $"Candidates:\n{candidatesString}"
            );
        }

        private void delete_bttn_Click(object sender, EventArgs e)
        {
            electionService.DeleteElection(election.Election.ElectionId);

            MessageBox.Show("Election deleted successfully!");
            OnUpdateRequested?.Invoke();
        }
    }
}
