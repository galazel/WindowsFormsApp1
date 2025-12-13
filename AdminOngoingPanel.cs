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
        private ElectionService electionService = new ElectionService();
        public AdminOngoingPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadOngoingElections();
        }
        public void LoadOngoingElections()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ongoing elections: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

    }
}
