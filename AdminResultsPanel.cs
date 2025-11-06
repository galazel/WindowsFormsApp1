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
    public partial class AdminResultsPanel : UserControl
    {
        public AdminResultsPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadResultsElections();

        }
        public void LoadResultsElections()
        {
            results_flow.Controls.Clear();
            foreach (var election in new ElectionService().GetElections())
            {
                var panel = new ResultsPanel(election);
                panel.OnUpdateRequested += LoadResultsElections;
                results_flow.Controls.Add(panel);
            }
        }
    }
}
