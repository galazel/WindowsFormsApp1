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
    public partial class Register : Form
    {
        private string imagePath = string.Empty;
        private int GetDepartmentId(string departmentName)
        {
            return new DepartmentService().GetDepartmentIdByName(departmentName);
        }
        public Register()
        {
            InitializeComponent();
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
            if (province_box.Text.Equals("")|| barangay_box.Text.Equals("") || province_box.Text.Equals("") || username_box.Text.Equals("") || password_box.Text.Equals("") || lastname_box.Text.Equals("") || firstname_box.Text.Equals("") || middle_box.Text.Equals("") || birthdate_date.Value.ToString().Equals("")|| contact_box.Text.Equals("") || email_box.Text.Equals("") || year_box.Text.Equals("") || section_box.Text.Equals("") || department_combo.SelectedItem.ToString().Equals("") || string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            else
            {
                Voter voter = new Voter
                {
                    FirstName = firstname_box.Text,
                    LastName = lastname_box.Text,
                    MiddleName = middle_box.Text,
                    BirthDate = birthdate_date.Value,
                    ContactNumber = contact_box.Text,
                    Email = email_box.Text,
                    Province = province_box.Text,
                    Barangay = barangay_box.Text,
                    City = city_box.Text,
                    Year = year_box.Text,
                    Section = section_box.Text,
                    Username = username_box.Text,
                    Password = password_box.Text,
                    Status = false,
                    DepartmentId = GetDepartmentId(department_combo.SelectedItem.ToString()),
                    Image = imagePath
                };
                new VoterService().AddVoter(voter);
            }

        }
    }
}
