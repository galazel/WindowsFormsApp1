using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class EndedPanel : UserControl
    {
        private WinnersService service;
        private ElectionDTO election;
        
        public EndedPanel(ElectionDTO electionDTO)
        {
            InitializeComponent();
            service = new WinnersService();
            department_name_label.Text = electionDTO.Department.DepartmentName;
            election_name_label.Text = electionDTO.Election.ElectionName;
            this.election = electionDTO;
            LoadWinners();
        }
        public void LoadWinners()
        {
            List<Winner> winners = election.Winners;
            foreach (var winner in winners)
            {
                winners_flow.Controls.Add(new WinnerPanel(winner)); 
            }
        }
        private void view_result_Click(object sender, EventArgs e)
        {
            new ElectionResults().ShowDialog();
        }
    }
}
