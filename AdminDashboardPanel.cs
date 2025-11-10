using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminDashboardPanel : UserControl
    {
        private DepartmentService departmentService;
        private PositionService positionService;

        public AdminDashboardPanel()
        {
            InitializeComponent();

            departmentService = new DepartmentService();
            positionService = new PositionService();

            LoadLabel();
            LoadDepartments();
            LoadPositions();
        }

        public void LoadLabel()
        {
            total_voters.Text = new VoterService().GetVotersCount();
            total_candidates.Text = new CandidateService().GetCandidatesCount();
            total_elections.Text = new ElectionService().GetElectionsCount();
            total_voted.Text = new VoterService().GetVotedCount();
        }

        public void LoadDepartments()
        {
            try
            {
                DataTable departments = new DataTable();
                departments.Columns.Add("DepartmentID", typeof(int));
                departments.Columns.Add("Department Name", typeof(string));

                using (var db = new eBotoDBEntities())
                {
                    foreach (var dept in db.Departments.ToList())
                        departments.Rows.Add(dept.DepartmentId, dept.DepartmentName);
                }

                departments_grid.DataSource = departments;

                if (departments_grid.Columns["DepartmentID"] != null)
                    departments_grid.Columns["DepartmentID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message);
            }
        }
        public void LoadPositions()
        {
            try
            {
                DataTable positions = new DataTable();
                positions.Columns.Add("PositionID", typeof(int));
                positions.Columns.Add("Position Name", typeof(string));

                using (var db = new eBotoDBEntities())
                {
                    foreach (var post in db.Positions.ToList())
                        positions.Rows.Add(post.PositionId, post.PositionName);
                }

                positions_grid.DataSource = positions;

                if (positions_grid.Columns["PositionID"] != null)
                    positions_grid.Columns["PositionID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading positions: " + ex.Message);
            }
        }

        private void add_department_Click(object sender, EventArgs e)
        {
            new Dialog(true).ShowDialog();
            LoadDepartments();
        }

        private void add_position_Click(object sender, EventArgs e)
        {
            new Dialog(false).ShowDialog();
            LoadPositions();
        }

        private void departments_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string deptName = departments_grid.Rows[e.RowIndex].Cells["Department Name"].Value?.ToString();

                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete '{deptName}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(departments_grid.Rows[e.RowIndex].Cells["DepartmentID"].Value);
                        departmentService.DeleteDepartment(id);
                        MessageBox.Show("Department deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDepartments();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting department: " + ex.Message);
                    }
                }
            }
        }

        private void positions_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string posName = positions_grid.Rows[e.RowIndex].Cells["Position Name"].Value?.ToString();

                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete '{posName}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(positions_grid.Rows[e.RowIndex].Cells["PositionID"].Value);
                        positionService.DeletePosition(id);
                        MessageBox.Show("Position deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPositions();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting position: " + ex.Message);
                    }
                }
            }
        }
        private void departments_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(departments_grid.Rows[e.RowIndex].Cells["DepartmentID"].Value);
                new EditDashboard(true, id).ShowDialog();
                LoadDepartments();
            }
        }

        private void positions_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(positions_grid.Rows[e.RowIndex].Cells["PositionID"].Value);
                new EditDashboard(false, id).ShowDialog();
                LoadPositions();
            }
        }
    }
}
