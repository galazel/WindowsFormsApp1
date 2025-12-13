using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    public partial class AdminDashboardPanel : UserControl
    {
        private DepartmentService departmentService = new DepartmentService();
        private PositionService positionService = new PositionService();
        private VoterService voterService = new VoterService();
        private CandidateService candidateService = new CandidateService();
        private ElectionService electionService = new ElectionService();
        private VotedCandidatesService votedCandidatesService = new VotedCandidatesService();

        public AdminDashboardPanel()
        {
            InitializeComponent();
           
            LoadLabel();
            LoadDepartments();
            LoadPositions();
            LoadVoters();
            LoadVotedCandidates();
        }
        public void LoadVoters()
        {
            try
            {
                DataTable voters = new DataTable();
                voters.Columns.Add("VoterId", typeof(int));
                voters.Columns.Add("Image", typeof(string));
                voters.Columns.Add("FirstName", typeof(string));
                voters.Columns.Add("LastName", typeof(string));
                voters.Columns.Add("MiddleName", typeof(string));
                voters.Columns.Add("DepartmentId", typeof(int));
                voters.Columns.Add("Section", typeof(string));
                voters.Columns.Add("Year", typeof(int));
                voters.Columns.Add("BirthDate", typeof(DateTime));
                voters.Columns.Add("ContactNumber", typeof(string));
                voters.Columns.Add("Email", typeof(string));
                voters.Columns.Add("Username", typeof(string));
                voters.Columns.Add("Password", typeof(string));
                voters.Columns.Add("Province", typeof(string));
                voters.Columns.Add("Barangay", typeof(string));
                voters.Columns.Add("City", typeof(string));
                voters.Columns.Add("Status", typeof(bool));

                foreach (var voter in voterService.GetAllVoters())
                    voters.Rows.Add(voter.VoterId, voter.Image, voter.FirstName, voter.LastName, voter.MiddleName, voter.DepartmentId, voter.Section, voter.Year, voter.BirthDate, voter.ContactNumber, voter.Email, voter.Username, voter.Password, voter.Province, voter.Barangay, voter.City, voter.Status);
                voters_view.DataSource = voters;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message);
            }
           
        }

        public void LoadLabel()
        {
            total_voters.Text = voterService.GetVotersCount();
            total_candidates.Text = candidateService.GetCandidatesCount();
            total_elections.Text = electionService.GetElectionsCount();
            total_voted.Text = voterService.GetVotedCount();
        }
        public void LoadDepartments()
        {
            try
            {
                DataTable departments = new DataTable();
                departments.Columns.Add("DepartmentID", typeof(int));
                departments.Columns.Add("Department Name", typeof(string));

                foreach (var dept in departmentService.GetAllDepartmentObjects())
                    departments.Rows.Add(dept.DepartmentId, dept.DepartmentName);

                departments_grid.DataSource = departments;
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message);
            }
        }
        public void LoadPositions()
        {
            try
            {
                DataTable positions = new DataTable();
                positions.Columns.Add("PositionID", typeof(int));
                positions.Columns.Add("Position Name", typeof(string));

                foreach (var post in positionService.GetAllPositionObjects())
                    positions.Rows.Add(post.PositionId, post.PositionName);

                positions_grid.DataSource = positions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading positions: " + ex.Message);
            }
           
        }
        public void LoadVotedCandidates()
        {
            try
            {
                DataTable votedCandidates = new DataTable();
                votedCandidates.Columns.Add("VotedCandidatesID", typeof(int));
                votedCandidates.Columns.Add("VoterID", typeof(int));
                votedCandidates.Columns.Add("CandidateID", typeof(int));
                votedCandidates.Columns.Add("ElectionID", typeof(int));
                votedCandidates.Columns.Add("PositionID", typeof(int));

                foreach (var post in votedCandidatesService.GetAllVotedCandidatesList())
                    votedCandidates.Rows.Add(post.VotedCandidatesId,post.VoterId, post.CandidateId, post.ElectionId, post.PositionId);

                voted_candidates_view.DataSource = votedCandidates;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading positions: " + ex.Message);
            }
        }
        private void add_department_Click(object sender, EventArgs e)
        {
            new Dialog(true).ShowDialog();
            LoadDepartments();
        }

        private void add_position_Click(object sender, EventArgs e)
        {
            new Dialog(false).ShowDialog();
            LoadPositions();
        }
        private void departments_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !departments_grid.Rows[e.RowIndex].Cells["DepartmentID"].Value.ToString().Equals(""))
            {
                int id = Convert.ToInt32(departments_grid.Rows[e.RowIndex].Cells["DepartmentID"].Value);
                new EditDashboard(true, id).ShowDialog();
                LoadDepartments();
            }
        }
        private void positions_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !positions_grid.Rows[e.RowIndex].Cells["PositionID"].Value.ToString().Equals(""))
            {
                int id = Convert.ToInt32(positions_grid.Rows[e.RowIndex].Cells["PositionID"].Value);
                new EditDashboard(false, id).ShowDialog();
                LoadPositions();
            }
        }
        private void departments_grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
                {
                    var confirm = MessageBox.Show("Delete this row?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        string name = Convert.ToString(departments_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        int id = departmentService.GetDepartmentIdByName(name);
                        departmentService.DeleteDepartment(id);
                        departments_grid.Rows.RemoveAt(e.RowIndex);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting department: " + ex.Message);
            }        
        }

        private void positions_grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
                {
                    var confirm = MessageBox.Show("Delete this row?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        if(electionService.DoesElectionStillOngoing())
                        {                             
                            MessageBox.Show("Cannot delete position while an election is ongoing or in record.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }else
                        {
                            string name = Convert.ToString(positions_grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                            int id = positionService.GetPositionId(name);
                            positionService.DeletePosition(id);
                            positions_grid.Rows.RemoveAt(e.RowIndex);
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting position: " + ex.Message);
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (departmentService.GetDepartmentsCount() == 0 &&
               positionService.GetPositionsCount() == 0 &&
               voterService.GetVotersCountInt() == 0)
                {
                    MessageBox.Show("No departments, positions, or voters found to clear.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    departmentService.ClearAllDepartments();
                    positionService.ClearAllPositions();
                    voterService.ClearAllVoters();
                    LoadDepartments();
                    LoadPositions();
                    LoadVoters();
                    LoadLabel();
                    LoadVotedCandidates();
                    MessageBox.Show("All departments, positions, and voters have been cleared.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
