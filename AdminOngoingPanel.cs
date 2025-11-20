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
    public partial class AdminOngoingPanel : UserControl
    {
        public AdminOngoingPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadOngoingElections();
        }
        public void LoadOngoingElections()
        {
                ongoing_flow.Controls.Clear();
                foreach (var election in new ElectionService().GetOngoingElections())
                {
                    var panel = new OngoingPanel(election);
                    panel.OnUpdateRequested += LoadOngoingElections;
                    ongoing_flow.Controls.Add(panel);
                }
        }

    }
}
