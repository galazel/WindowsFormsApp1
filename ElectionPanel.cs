using System;
using System.Collections.Generic;
using System.Text;
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

        public event Action OnUpdateRequested;

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

        public ElectionPanel()
        {
            InitializeComponent();
        }

        private void start_bttn_Click(object sender, EventArgs e)
        {
            status = !status;
            electionService.UpdateElectionStatus(id);
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
                $"Description: {description}\n" +
                $"Candidates:\n{candidatesString}"
            );
        }

        private void delete_bttn_Click(object sender, EventArgs e)
        {
            electionService.DeleteElection(id);

            MessageBox.Show("Election deleted successfully!");
            OnUpdateRequested?.Invoke();
        }
    }
}
