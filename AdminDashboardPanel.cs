
using Microsoft.VisualBasic;
using System;
using System.Data;

using System.Linq;


using System.Windows.Forms;
using System.Windows.Input;

namespace WindowsFormsApp1
{
    public partial class AdminDashboardPanel : UserControl
    {
        private DepartmentService departmentService;
        private PositionService positionService;
        public AdminDashboardPanel()
        {
            InitializeComponent();
            LoadLabel();
            departmentService = new DepartmentService();
            positionService = new PositionService();
            LoadDepartments();
            LoadPositions();
        }
        public void  LoadLabel()
        {
            using (var db = new eBotoDBEntities())
            {

                total_voters.Text = db.Voters.Count().ToString();
                total_candidates.Text = db.Candidates.Count().ToString();
                total_elections.Text = db.Elections.Count().ToString();
                total_voted.Text = db.Voters.Where(v => v.Status == true).Count().ToString();
            }
        
        }

        public void LoadDepartments()
        {
            DataTable departments = new DataTable();
            departments.Columns.Add("DepartmentID", typeof(int));
            departments.Columns.Add("Department Name", typeof(string));

            using (var db = new eBotoDBEntities())
            {
                foreach (var dept in db.Departments.ToList())
                    departments.Rows.Add(dept.DepartmentId, dept.DepartmentName);
                departments_grid.DataSource = departments;
            }

        }

        public void LoadPositions() {
            DataTable positions = new DataTable();
            positions.Columns.Add("PositionID", typeof(int));
            positions.Columns.Add("Position Name", typeof(string));

            using (var db = new eBotoDBEntities())
            {
                foreach (var post in db.Positions.ToList())
                    positions.Rows.Add(post.PositionId, post.PositionName);
                positions_grid.DataSource = positions;
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
                        MessageBox.Show(""+id);
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

        private void positions_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            int id = Convert.ToInt32(departments_grid.Rows[e.RowIndex].Cells["DepartmentID"].Value);
            new EditDashboard(true,id).ShowDialog();
            LoadDepartments();
        }

        private void positions_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(positions_grid.Rows[e.RowIndex].Cells["PositionID"].Value);
            new EditDashboard(false,id).ShowDialog();
            LoadPositions();
        }
    }
}
