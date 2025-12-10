using System;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminElectionsPanel : UserControl
    {
        private ElectionService electionService;
        public AdminElectionsPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            electionService = new ElectionService();
            LoadElections();       
        }
        public void LoadElections()
        {
            var elections = electionService.GetElections();
            elections_flow.Controls.Clear();
            foreach (var election in elections)
            {
              var panel = new ElectionPanel(election, elections_flow);
              elections_flow.Controls.Add(panel);
            }
            
        }
        private void create_election_bttn_Click(object sender, EventArgs e)
        {
            new CreateElection(this.elections_flow).ShowDialog();
        }
    }
}
