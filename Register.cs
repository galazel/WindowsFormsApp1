using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        private readonly VoterService voterService = new VoterService();
        private readonly DepartmentService departmentService = new DepartmentService();
        private readonly ElectionService electionService = new ElectionService();

        private string imagePath = string.Empty;

        public Register()
        {
            InitializeComponent();

            try
            {
                department_combo.Items.AddRange(
                    departmentService.GetAllDepartments().ToArray()
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load departments.\n" + ex.Message);
            }
        }

        private void photo_box_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        photo_box.Image = Image.FromFile(openFileDialog.FileName);
                        imagePath = openFileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load image.\n" + ex.Message);
            }
        }

        private void register_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Safe null checks
                if (string.IsNullOrWhiteSpace(firstname_box.Text) ||
                    string.IsNullOrWhiteSpace(lastname_box.Text) ||
                    string.IsNullOrWhiteSpace(middle_box.Text) ||
                    string.IsNullOrWhiteSpace(username_box.Text) ||
                    string.IsNullOrWhiteSpace(password_box.Text) ||
                    string.IsNullOrWhiteSpace(contact_box.Text) ||
                    string.IsNullOrWhiteSpace(email_box.Text) ||
                    string.IsNullOrWhiteSpace(province_box.Text) ||
                    string.IsNullOrWhiteSpace(barangay_box.Text) ||
                    string.IsNullOrWhiteSpace(city_box.Text) ||
                    string.IsNullOrWhiteSpace(year_box.Text) ||
                    string.IsNullOrWhiteSpace(section_box.Text) ||
                    department_combo.SelectedItem == null ||
                    string.IsNullOrEmpty(imagePath))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }else if(username_box.Text.ToLower() == "admin")
                {
                    MessageBox.Show("The name 'admin' is reserved. Please choose a different name.");
                    return;
                }else if(firstname_box.Text.Length < 8 || lastname_box.Text.Length < 8 || middle_box.Text.Length < 8)
                {
                    MessageBox.Show("First name must be at least 2 characters long.");
                    return;

                }
                int age = DateTime.Now.Year - birthdate_date.Value.Year;

                if (age < 18)
                {
                    MessageBox.Show("You are not allowed to vote.");
                    return;
                }else if(age > 110)
                {
                    MessageBox.Show("Please enter a valid birthdate.");
                    return;
                }

                if (username_box.Text.Length < 8 || password_box.Text.Length < 8)
                {
                    MessageBox.Show("Username and Password must be at least 8 characters long.");
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

                int departmentId = departmentService
                    .GetDepartmentIdByName(department_combo.SelectedItem.ToString());

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
                    DepartmentId = departmentId,
                    Image = imagePath
                };

                if (voterService.DoesVoterAlreadyExisted(voter))
                {
                    MessageBox.Show("Voter already exists!");
                    return;
                }

                if (!voterService.AddVoter(voter))
                {
                    MessageBox.Show("Registration failed.");
                    return;
                }

                MessageBox.Show("Registration Successful!");
                this.Hide();

                bool hasActiveElection =
                    electionService.FindDepartmentActiveElection(departmentId);

                VoterDTO voterDTO = hasActiveElection
                    ? voterService.GetVoterDepartmentElection(voter.VoterId)
                    : voterService.GetVoterDepartment(voter.VoterId);

                new VoterDashboard(voterDTO).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed.\n" + ex.Message);
            }
        }

        public bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public bool IsValidContactNumber(string contactNumber)
        {
            return Regex.IsMatch(contactNumber, @"^(09\d{9}|\+639\d{9})$");
        }

        private void return_icon_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }
    }
}
