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
        private FlowLayoutPanel childLayout;

        public ElectionPanel(ElectionDTO electionDto, FlowLayoutPanel parentLayout)
        {
            InitializeComponent();
            electionService = new ElectionService();
            this.childLayout = parentLayout;
            this.election = electionDto;
            election_name_label.Text = electionDto.Election.ElectionName;
            department_label.Text = electionDto.Department.DepartmentName;
            this.candidates = electionDto.Candidates;
        }

        private void start_bttn_Click(object sender, EventArgs e)
        {
            if(electionService.DoesElectionInDepartmentStillOngoing(election.Department.DepartmentId))
            {
                MessageBox.Show("Another election is already ongoing in your deparment. Please end that election before starting a new one.");
                return;
            }else
            {
                election.Election.Status = !election.Election.Status;
                electionService.UpdateElectionStatus(election.Election.ElectionId);
                MessageBox.Show("Election status updated successfully!");
                Others.LoadElections(childLayout);
            }

                
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
            Others.LoadElections(childLayout);
        }

        private void update_bttn_Click(object sender, EventArgs e)
        {
            new CreateElection(childLayout, election, "edit").ShowDialog();
        }
    }
}
