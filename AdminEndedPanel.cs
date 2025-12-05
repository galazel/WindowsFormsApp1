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
            if(new WinnersService().WinnersCount() != 0)
            {
                foreach (var election in new ElectionService().GetEndedElections())
                {
                    var panel = new EndedPanel(election);
                    ended_flow.Controls.Add(panel);
                }
            }
            
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All winners data has been cleared.");
            new WinnersService().ClearAll();
            new ElectionService().ClearEndedElections();
            ended_flow.Controls.Clear();

        }
    }
}
