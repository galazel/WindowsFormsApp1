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

        public static bool FlowState = false;

        public static void LoadElections(FlowLayoutPanel electionsFlow)
        {
            electionsFlow.Controls.Clear();
            ElectionService electionService = new ElectionService();
            foreach(var election in electionService.GetElections())
                electionsFlow.Controls.Add(new ElectionPanel(election, electionsFlow));    
        }
        public static void LoadOngoingElections(FlowLayoutPanel electionsFlow)
        {
            electionsFlow.Controls.Clear();
            ElectionService electionService = new ElectionService();
            foreach (var election in electionService.GetOngoingElections())
                electionsFlow.Controls.Add(new OngoingPanel(election));
        }
        public static void LoadEndedElections(FlowLayoutPanel endElectionsFlow)
        {
            endElectionsFlow.Controls.Clear();
            foreach (var election in new ElectionService().GetEndedElections())
                endElectionsFlow.Controls.Add(new EndedPanel(election)); 
        }

   

    }
}
