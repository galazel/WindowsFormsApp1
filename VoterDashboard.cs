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
        public VoterDashboard(VoterDTO voter)
        {
            InitializeComponent();
            voter_image.Image = Image.FromFile(voter.Voter.Image);
            name_label.Text = voter.Voter.FirstName + " " + voter.Voter.MiddleName +" "+ voter.Voter.LastName;
            status_label.Text = voter.Voter.Status ? "Status: Voted" : "Status: Not Voted";
            department_label.Text = "Department: " + voter.Department.DepartmentName;
            year_label.Text = "Year: " + voter.Voter.Year;
            section_label.Text = "Section: " + voter.Voter.Section;
            birthday_label.Text = "Birthdate: " + voter.Voter.BirthDate.ToShortDateString();
            contact_label.Text = "Contact Number: " + voter.Voter.ContactNumber;
            email_label.Text = "Email: " + voter.Voter.Email;

            greetings_label.Text = "Welcome, " + voter.Voter.FirstName + " " + voter.Voter.LastName + "!";
            status_election_label.Text = "Election Status: " + (voter.Election.Status ? "Active" : "Inactive");
            election_name.Text = "Election: " + voter.Election.ElectionName;
            department_label.Text = "Department: " + voter.Department.DepartmentName;
            if(voter.Election.Status)
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
}
