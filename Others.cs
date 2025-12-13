using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Others
    {
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string Partylist { get; set; }
        public string Motto { get; set; }
        public string Image { get; set; }
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }

        public static List<Others> othersList = new List<Others>();
        public static Dictionary<string, string> oldNames = new Dictionary<string, string>();
        public static bool FlowState = false;

        public static void LoadElections(FlowLayoutPanel electionsFlow)
        {
            try
            {
                electionsFlow.Controls.Clear();
                ElectionService electionService = new ElectionService();

                foreach (var election in electionService.GetElections())
                    electionsFlow.Controls.Add(new ElectionPanel(election, electionsFlow));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading elections.\n" + ex.Message);
            }
        }

        public static void LoadOngoingElections(FlowLayoutPanel electionsFlow)
        {
            try
            {
                electionsFlow.Controls.Clear();
                ElectionService electionService = new ElectionService();

                foreach (var election in electionService.GetOngoingElections())
                    electionsFlow.Controls.Add(new OngoingPanel(election));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ongoing elections.\n" + ex.Message);
            }
        }

        public static void LoadEndedElections(FlowLayoutPanel endElectionsFlow)
        {
            try
            {
                endElectionsFlow.Controls.Clear();
                ElectionService electionService = new ElectionService();

                foreach (var election in electionService.GetEndedElections())
                    endElectionsFlow.Controls.Add(new EndedPanel(election));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ended elections.\n" + ex.Message);
            }
        }

        public static void LoadCandidates(ListBox candidateList)
        {
            try
            {
                candidateList.Items.Clear();

                PositionService positionService = new PositionService();

                foreach (var candidate in othersList)
                {
                    candidateList.Items.Add(
                        candidate.CandidateName.ToUpper() +
                        " ===================> " +
                        positionService.GetPositionName(candidate.PositionId)
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading candidates.\n" + ex.Message);
            }
        }

        public static void LoadCandidatesForEdit(ListBox candidateList)
        {
            try
            {
                LoadCandidates(candidateList); // reuse logic
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading candidates for edit.\n" + ex.Message);
            }
        }
    }
}
