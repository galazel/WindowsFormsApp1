
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    internal class AdminController
    {
        public static void AdminTabControl(string tabName,Panel panel)
        {
            switch(tabName)
            {
                case "Dashboard":
                    panel.Controls.Clear();
                    panel.Controls.Add(new AdminDashboardPanel());
                    break;
                case "Elections":
                    panel.Controls.Clear();
                    panel.Controls.Add(new AdminElectionsPanel());
                    break;
                case "Ongoing":
                    panel.Controls.Clear();
                    panel.Controls.Add(new AdminOngoingPanel());
                    break;
                case "Results":
                    panel.Controls.Clear();
                    panel.Controls.Add(new AdminEndedPanel());
                    break;
                default:
                  
                    break;
            }

        }
    }
}
