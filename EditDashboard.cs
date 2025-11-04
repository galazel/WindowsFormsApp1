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
    public partial class EditDashboard : Form
    {
        private DepartmentService departmentService;
        private PositionService positionService;
        private bool isTrue;
        private int id;
        public EditDashboard(bool isDepartment, int id)
        {
            InitializeComponent();
            this.isTrue = isDepartment;
            this.id = id;
            departmentService = new DepartmentService();
            positionService = new PositionService();

            if (isDepartment)
                label_add.Text = "EDIT DEPARTMENT";
            else
                label_add.Text = "EDIT POSITION";
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (add_box.Text.Equals(""))
            {
                MessageBox.Show("Input the required field");
                return;
            }
            else
            {
                string item = add_box.Text;
                if (isTrue)
                {
                    departmentService.EditDepartment(id,item);
                    MessageBox.Show("Edited Successfully");
                    this.Hide();
                }
                else
                {
                    positionService.EditPosition(id,item);
                    MessageBox.Show("Edited Successfully");
                    this.Hide();
                }
            }
        }
    }
}
