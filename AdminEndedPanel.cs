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
        public AdminEndedPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadEndedElections();

        }
        public void LoadEndedElections()
        {
            ended_flow.Controls.Clear();
            foreach (var election in new ElectionService().GetEndedElections())
            {
               var panel = new EndedPanel(election);
               ended_flow.Controls.Add(panel);
            }
            
        }
        private void clear_button_Click(object sender, EventArgs e)
        {
            if (new DepartmentService().GetDepartmentsCount() == 0)
            {
                MessageBox.Show("No departments found to clear winners data.", "No Departments Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (new WinnersService().WinnersCount() == 0)
            {
                MessageBox.Show("No winners data found to clear.", "No Winners Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else
            {
                MessageBox.Show("All winners data has been cleared.");
                new WinnersService().ClearAll();
                new ElectionService().ClearEndedElections();
                ended_flow.Controls.Clear();
            }
               
        }
    }
}
