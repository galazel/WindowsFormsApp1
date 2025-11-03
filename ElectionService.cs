using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
