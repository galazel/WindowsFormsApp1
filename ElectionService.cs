using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    internal class ElectionService
    {
        public int GetElectionId(string electionName)
        {
            using (var db = new eBotoDBEntities())
            {
                var election = db.Elections.FirstOrDefault(e => e.ElectionName == electionName);
                return election != null ? election.ElectionId : -1;
            }
        }
        public void AddElection(string electionName, string description, bool isActive, int departmentId)
        {
            using (var db = new eBotoDBEntities())
            {
                Election newElection = new Election
                {
                    ElectionName = electionName,
                    Description = description,
                    Status = isActive,
                    DepartmentId = departmentId
                };
                db.Elections.Add(newElection);
                db.SaveChanges();
            }
        }
        public List<ElectionDTO> GetElections()
        {
            var list = new List<ElectionDTO>();
            DepartmentService departmentService = new DepartmentService();

            using (var context = new eBotoDBEntities())
            { 
                var elections =  context.Elections.Include(e => e.Candidates).Include(e => e.Department).Where(e => e.Status == false).ToList();

                foreach (var election in elections)
                {
                    ElectionDTO electionDTO = new ElectionDTO();
                    electionDTO.ElectionName = election.ElectionName;
                    electionDTO.Department = election.Department.DepartmentName;
                    electionDTO.Status = election.Status == true ? "Ongoing" : "Not Started";
                    electionDTO.Description = election.Description;
                    electionDTO.Candidates = election.Candidates.ToList();
                    list.Add(electionDTO);
                }

            }
            return list;
        }
    }
}
