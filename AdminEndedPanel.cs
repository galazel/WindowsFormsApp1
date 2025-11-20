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
    }
}
