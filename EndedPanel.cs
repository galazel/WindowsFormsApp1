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
    public partial class EndedPanel : UserControl
    {
        public EndedPanel(ElectionDTO electionDTO)
        {
            InitializeComponent();
            department_name_label.Text = electionDTO.Department;
            election_name_label.Text = electionDTO.ElectionName;
        }

        private void view_result_Click(object sender, EventArgs e)
        {
            new ElectionResults().ShowDialog();
        }
    }
}
