using System;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminElectionsPanel : UserControl
    {
        private ElectionService electionService = new ElectionService();
        private DepartmentService departmentService = new DepartmentService();
        private PositionService positionService = new PositionService();
        public AdminElectionsPanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadElections();       
        }
        public void LoadElections()
        {
            try
            {
                var elections = electionService.GetElections();
                elections_flow.Controls.Clear();
                foreach (var election in elections)
                {
                    var panel = new ElectionPanel(election, elections_flow);
                    elections_flow.Controls.Add(panel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading elections: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void create_election_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (departmentService.GetDepartmentsCount() == 0)
                {
                    MessageBox.Show("Please add a department before creating an election.", "No Departments Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (positionService.GetPositionsCount() == 0)
                {
                    MessageBox.Show("Please add a position before creating an election.", "No Positions Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    new CreateElection(this.elections_flow).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
