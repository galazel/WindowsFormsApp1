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
    public partial class SummaryPanel : UserControl
    {
        public SummaryPanel(string candidateName, string positionName)
        {
            InitializeComponent();
            position_label.Text = positionName;
            candidate_label.Text = candidateName;
        }
    }
}
