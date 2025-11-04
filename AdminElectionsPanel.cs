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
    public partial class AdminElectionsPanel : UserControl
    {
        public AdminElectionsPanel()
        {
            InitializeComponent();
            LoadElectionPanels();
        }

        private void create_election_bttn_Click(object sender, EventArgs e)
        {
            new CreateElection().ShowDialog();
        }
        public void LoadElectionPanels()
        {
            Others.LoadElections(this.elections_flow);
        }
    }
}
