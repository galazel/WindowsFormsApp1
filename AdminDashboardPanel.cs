using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminDashboardPanel : UserControl
    {
        public AdminDashboardPanel()
        {
            InitializeComponent();
            LoadData();
        }
        public void  LoadData()
        {
            using(var db = new eBotoDBEntities())
            {

                  total_voters.Text = db.Voters.Count().ToString();
                  total_candidates.Text = db.Candidates.Count().ToString();
                  total_elections.Text = db.Elections.Count().ToString();
                  total_voted.Text = db.Voters.Where(v => v.Status == true).Count().ToString();

               DataTable departments = new DataTable();
               departments.Columns.Add("Department ID", typeof(int));
               departments.Columns.Add("Department Name", typeof(string));
                foreach(var dept in db.Departments.ToList())
                     departments.Rows.Add(dept.DepartmentId, dept.DepartmentName);
                departments_grid.DataSource = departments;


                DataTable positions = new DataTable();
                positions.Columns.Add("Position ID", typeof(int));
                positions.Columns.Add("Position Name", typeof(string));
                foreach (var post in db.Positions.ToList())
                    positions.Rows.Add(post.PositionId, post.PositionName);
                positions_grid.DataSource = positions;

            }

        }
    }
}
