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
    public partial class VoterDashboard : Form
    {
        private VoterDTO voterDTO;
        public VoterDashboard(VoterDTO voter)
        {
            InitializeComponent();
            this.voterDTO = voter;

            voter_image.Image = Image.FromFile(voter.Voter.Image);
            name_label.Text = voter.Voter.FirstName + " " + voter.Voter.MiddleName + " " + voter.Voter.LastName;
            status_label.Text = voter.Voter.Status ? "Status: Voted" : "Status: Not Voted";
            department_label.Text = "Department: " + voter.Department.DepartmentName;
            year_label.Text = "Year: " + voter.Voter.Year;
            section_label.Text = "Section: " + voter.Voter.Section;
            birthday_label.Text = "Birthdate: " + voter.Voter.BirthDate.ToShortDateString();
            contact_label.Text = "Contact Number: " + voter.Voter.ContactNumber;
            email_label.Text = "Email: " + voter.Voter.Email;
            department_label.Text = voter.Department.DepartmentName.ToUpper();

            if (voter.Election == null)
            { 
                status_election_label.Text = "";
                election_name.Text = "NO ELECTION CREATED";
                election_department_label.Text = "";
                vote_now_bttn.Enabled = false;
                vote_now_bttn.Text = "No Election Available";
                Label noElectionLabel = new Label();
                noElectionLabel.Text = "No Election Available";
                noElectionLabel.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                noElectionLabel.ForeColor = Color.Red;
                live_results_flow.Controls.Add(noElectionLabel);

            }
            else
            {
                status_election_label.Text = voter.Election.Status ? "Started Now" : "Not Yet Started";
                election_name.Text = voter.Election.ElectionName.ToUpper();
                election_department_label.Text = voter.Department.DepartmentName.ToUpper();
               
                if (voter.Election.Status)
                {
                    vote_now_bttn.Enabled = true;
                    vote_now_bttn.Text = "Vote Now!";
                }
                else
                {
                    vote_now_bttn.Enabled = false;
                    vote_now_bttn.Text = "Election is Inactive";
                }
            }

        }
        private void vote_now_bttn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+voterDTO.Positions );
        }

        private void logout_icon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            this.Hide();
            new Login().ShowDialog();
        }
    }
}
