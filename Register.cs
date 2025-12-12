using System;

using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        private VoterService voterService = new VoterService();
        private string imagePath = string.Empty;
        
        private int GetDepartmentId(string departmentName)
        {
            return new DepartmentService().GetDepartmentIdByName(departmentName);
        }
        public Register()
        {
            InitializeComponent();
            department_combo.Items.AddRange(new DepartmentService().GetAllDepartments().ToArray());
        }

        private void photo_box_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                photo_box.Image = Image.FromFile(openFileDialog.FileName);
                imagePath = openFileDialog.FileName;
            }
        }

        private void register_bttn_Click(object sender, EventArgs e)
        {
            
            if (province_box.Text.Equals("") || barangay_box.Text.Equals("") || province_box.Text.Equals("") || username_box.Text.Equals("") || password_box.Text.Equals("") || lastname_box.Text.Equals("") || firstname_box.Text.Equals("") || middle_box.Text.Equals("") || birthdate_date.Value.ToString().Equals("") || contact_box.Text.Equals("") || email_box.Text.Equals("") || year_box.Text.Equals("") || section_box.Text.Equals("") || department_combo.SelectedItem.ToString().Equals("") || string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            int age = 2025 - birthdate_date.Value.Year;
            Voter voter = new Voter
            {
                FirstName = firstname_box.Text.ToUpper(),
                LastName = lastname_box.Text.ToUpper(),
                MiddleName = middle_box.Text.ToUpper(),
                BirthDate = birthdate_date.Value.Date,
                ContactNumber = contact_box.Text,
                Email = email_box.Text.ToUpper(),
                Province = province_box.Text.ToUpper(),
                Barangay = barangay_box.Text.ToUpper(),
                City = city_box.Text.ToUpper(),
                Year = year_box.Text.ToUpper(),
                Section = section_box.Text.ToUpper(),
                Username = username_box.Text,
                Password = PasswordHasher.Hash(password_box.Text),
                Status = false,
                DepartmentId = GetDepartmentId(department_combo.SelectedItem.ToString()),
                Image = imagePath
            };

            if (age < 18)
            {
                MessageBox.Show("You are not allowed to vote");
                return;
            }
            if(username_box.Text.Length < 8 || password_box.Text.Length < 8)
            {
                MessageBox.Show("Username and Password must be at least 5 characters long.");
                return;
            }

            if (!IsValidContactNumber(contact_box.Text))
            {
                MessageBox.Show("Please enter a valid contact number.");
                return;
            }
            if (!IsValidEmail(email_box.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            if (voterService.DoesVoterAlreadyExisted(voter))
            {
                MessageBox.Show("Voter already exists!");
                return;
            }
           
            else if (new VoterService().AddVoter(voter))
            {
                MessageBox.Show("Registration Successful!");
                this.Hide();

                int departmentId = voter.DepartmentId.HasValue ? voter.DepartmentId.Value : -1;

                if (!new ElectionService().FindDepartmentActiveElection(departmentId))
                {
                    VoterDTO voterDTO = new VoterService().GetVoterDepartment(voter.VoterId);
                    new VoterDashboard(voterDTO).ShowDialog();
                }
                else
                {
                    VoterDTO voterDTO = new VoterService().GetVoterDepartmentElection(voter.VoterId);
                    new VoterDashboard(voterDTO).ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Voter already exists!");
            }
        }

        public bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        public bool IsValidContactNumber(string contactNumber)
        {
            string pattern = @"^(09\d{9}|\+639\d{9})$";
            return Regex.IsMatch(contactNumber, pattern);
        }

        private void return_icon_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }
    }
}
