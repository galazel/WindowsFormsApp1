using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Others
    {
        public String CandidateName { get; set; }
        public String Partylist { get; set; }
        public String Motto { get; set; }
        public String Image { get; set; }
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }

        public static List<Others> othersList = othersList = new List<Others>();

        public static void LoadElections(FlowLayoutPanel electionsFlow)
        {
            ElectionService electionService = new ElectionService();
            
            foreach(var election in electionService.GetElections())
            {
                electionsFlow.Controls.Add(new ElectionPanel(election));
            }
            
        }

    }
}
