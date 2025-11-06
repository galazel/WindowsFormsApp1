using System;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminElectionsPanel : UserControl
    {
        public AdminElectionsPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadElections();       

        }
        public void LoadElections()
        {
            elections_flow.Controls.Clear();

            foreach (var election in new ElectionService().GetElections())
            {
                var panel = new ElectionPanel(election);
                panel.OnUpdateRequested += LoadElections;
                elections_flow.Controls.Add(panel);
            }
        }



        private void create_election_bttn_Click(object sender, EventArgs e)
        {
            new CreateElection(this.elections_flow).ShowDialog();
        }
    }
}
