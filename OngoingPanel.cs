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
    public partial class OngoingPanel : UserControl
    {
        private List<Candidate> candidates;
        private ElectionService electionService;
        public event Action OnUpdateRequested;
        private ElectionDTO electionDTO;
        public OngoingPanel(ElectionDTO electionDto)
        {
            InitializeComponent();
            electionService = new ElectionService();
            election_name_label.Text = electionDto.Election.ElectionName;
            department_label.Text = electionDto.Department.DepartmentName;
            this.electionDTO = electionDto;
            LoadOngoingResults();

        }
        public void LoadOngoingResults()
        {
            foreach (var position in electionDTO.Positions)
            {
                List<Candidate> candidates = new List<Candidate>();

                foreach (var candidate in electionDTO.Candidates)
                    if (candidate.PositionId == position.PositionId)
                        candidates.Add(candidate);

                ongoing_results_flow.Controls.Add(new LiveResults(position.PositionName, candidates, new VotedCandidatesService().GetCandidatesAndVotes(electionDTO.Election.ElectionId)));
            }
        }

        private void view_details_bttn_Click(object sender, EventArgs e)
        {
            StringBuilder candidatesString = new StringBuilder();
            PositionService positionService = new PositionService();

            foreach (Candidate candidate in electionDTO.Candidates)
                candidatesString.AppendLine(candidate.CandidateName + "----------" + positionService.GetPositionName(candidate.PositionId)+ "----------");
            MessageBox.Show($"Election Name: {election_name_label.Text}\nDepartment: {department_label.Text}\nDescription: {electionDTO.Department.DepartmentName}\nCandidates: \n" + candidatesString);
        }

        private void end_bttn_Click(object sender, EventArgs e)
        {
            electionService.SetWinners(electionDTO.Election.ElectionId);
            electionService.SetEndStatus(electionDTO.Election.ElectionId);
            MessageBox.Show("Election ended successfully!");
            OnUpdateRequested?.Invoke();
            this.Hide();
        }
    }
}
