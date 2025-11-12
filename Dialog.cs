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
    public partial class Dialog : Form
    {
        private DepartmentService departmentService;
        private PositionService positionService;
        private bool isTrue;
        public Dialog(bool isDepartment)
        {
            InitializeComponent();
            this.isTrue = isDepartment;
            departmentService = new DepartmentService();
            positionService = new PositionService();

            if (isDepartment)
                label_add.Text = "ADD DEPARTMENT";
            else
                label_add.Text = "ADD POSITION";
        }

        private void add_position_Click(object sender, EventArgs e)
        {
           if(add_box.Text.Equals(""))
            {
                MessageBox.Show("Input the required field");
                return;
            }
            else
            {
                string item = add_box.Text;
                if (isTrue)
                {
                    if (departmentService.DoesExists(item))
                    {
                        MessageBox.Show("Department already existed.");
                        return;
                    }

                    departmentService.SaveDepartment(item);
                    MessageBox.Show("Added Successfully");
                    this.Hide();
                }else
                {
                    if (positionService.DoesExists(item))
                    {
                        MessageBox.Show("Position already existed.");
                        return;
                    }
                    positionService.SavePosition(item);
                    MessageBox.Show("Added Successfully");
                    this.Hide();
                }
            }
        }
        
    }
}
