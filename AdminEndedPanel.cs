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
    public partial class AdminEndedPanel : UserControl
    {
        private ElectionService electionService = new ElectionService();
        private WinnersService winnersService = new WinnersService();
        private DepartmentService departmentService = new DepartmentService();
        public AdminEndedPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadEndedElections();

        }
        public void LoadEndedElections()
        {
            try
            {
                ended_flow.Controls.Clear();
                foreach (var election in electionService.GetEndedElections())
                {
                    var panel = new EndedPanel(election);
                    ended_flow.Controls.Add(panel);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while loading ended elections: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void clear_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (departmentService.GetDepartmentsCount() == 0)
                {
                    MessageBox.Show("No departments found to clear winners data.", "No Departments Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //else if (winnersService.WinnersCount() == 0)
                //{
                //    MessageBox.Show("No winners data found to clear.", "No Winners Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
                else
                {
                    winnersService.ClearAll();
                    electionService.ClearEndedElections();
                    ended_flow.Controls.Clear();
                    Others.othersList.Clear();
                    MessageBox.Show("All winners data has been cleared.");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while clearing winners data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
