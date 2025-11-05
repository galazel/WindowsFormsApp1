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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_bttn_Click(object sender, EventArgs e)
        {
            if (username_box.Text.Equals("admin") && password_box.Text.Equals("admin123"))
            {
                this.Hide();
                new AdminDashboard(new AdminDashboardPanel()).ShowDialog();
            }
            else if (username_box.Text.Equals("") || password_box.Text.Equals(""))
                MessageBox.Show("Please input the required fields");
            else
            {
                if(!new VoterService().DoesVoterAlreadyExisted(username_box.Text))
                {
                    MessageBox.Show("No registered voters found. Please register first.");
                    return;
                }else
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    new VoterDashboard(new VoterService().GetVoterDepartmentElection(new VoterService().GetVoterIdByUsername(username_box.Text))).ShowDialog();
                }
            }
        }

        private void register_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().ShowDialog();
            
        }
    }
}
