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
        private ElectionService electionService;
        public AdminOngoingPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            electionService = new ElectionService();
            LoadOngoingElections();
        }
        public void LoadOngoingElections()
        {
            var ongoingElections = electionService.GetOngoingElections();
            ongoing_flow.Controls.Clear();
            foreach (var election in ongoingElections)
            {
              var panel = new OngoingPanel(election);
              panel.OnUpdateRequested += LoadOngoingElections;
              ongoing_flow.Controls.Add(panel);
            }
        }

    }
}
