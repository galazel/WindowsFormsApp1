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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard(UserControl dashboardPanel)
        {
            InitializeComponent();
            admin_panel.Controls.Add(dashboardPanel);
        }

        private void dashboard_icon_Click(object sender, EventArgs e)
        {
            AdminController.AdminTabControl("Dashboard",this.admin_panel);
        }

        private void elections_icon_Click(object sender, EventArgs e)
        {
            AdminController.AdminTabControl("Elections", this.admin_panel);

        }

        private void results_icons_Click(object sender, EventArgs e)
        {
            AdminController.AdminTabControl("Results", this.admin_panel);

        }

        private void logout_icon_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }
    }
}
