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
        private string description;
        private int id;
        private ElectionService electionService;
        public OngoingPanel(ElectionDTO electionDto)
        {
            InitializeComponent();
            electionService = new ElectionService();
            election_name_label.Text = electionDto.ElectionName;
            department_label.Text = electionDto.Department;
            this.id = electionDto.ElectionId;
            this.candidates = electionDto.Candidates;
            this.description = electionDto.Description;
        }

        private void view_details_bttn_Click(object sender, EventArgs e)
        {
            StringBuilder candidatesString = new StringBuilder();
            PositionService positionService = new PositionService();

            foreach (Candidate candidate in candidates)
            {
                candidatesString.AppendLine(candidate.CandidateName + "----------" + positionService.GetPositionName(candidate.PositionId)+ "----------");
            }
            MessageBox.Show($"Election Name: {election_name_label.Text}\nDepartment: {department_label.Text}\nDescription: {description}\nCandidates: \n" + candidatesString);
        }

        private void end_bttn_Click(object sender, EventArgs e)
        {

        }
    }
}
