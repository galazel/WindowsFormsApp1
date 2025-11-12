using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.InteropServices.WindowsRuntime;

namespace WindowsFormsApp1
{
    internal class ElectionService : DBConnection
    {
        public int GetElectionId(string electionName)
        {
                var election = db.Elections.FirstOrDefault(e => e.ElectionName == electionName);
                return election != null ? election.ElectionId : -1;
        }
        public void AddElection(string electionName, string description, bool isActive, int departmentId)
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
        public List<ElectionDTO> GetElections()
        {
            var list = new List<ElectionDTO>();
            DepartmentService departmentService = new DepartmentService();

                var elections =  db.Elections.Include(e => e.Candidates).Include(e => e.Department).Where(e => e.Status == false).ToList();

                foreach (var election in elections)
                {
                    ElectionDTO electionDTO = new ElectionDTO();
                    electionDTO.ElectionId = election.ElectionId;
                    electionDTO.ElectionName = election.ElectionName;
                    electionDTO.Department = election.Department.DepartmentName;
                    electionDTO.Status = election.Status;
                    electionDTO.Description = election.Description;
                    electionDTO.Candidates = election.Candidates.ToList();
                    list.Add(electionDTO);
                }

            return list;
        }
        public List<ElectionDTO> GetOngoingElections()
        {
            var list = new List<ElectionDTO>();
            DepartmentService departmentService = new DepartmentService();
                var elections = db.Elections.Include(e => e.Candidates).Include(e => e.Department).Where(e => e.Status == true &&  e.EndStatus == false).ToList();
                foreach (var election in elections)
                {
                    ElectionDTO electionDTO = new ElectionDTO();
                    electionDTO.ElectionId = election.ElectionId;
                    electionDTO.ElectionName = election.ElectionName;
                    electionDTO.Department = election.Department.DepartmentName;
                    electionDTO.Description = election.Description;
                    electionDTO.Candidates = election.Candidates.ToList();
                    list.Add(electionDTO);
                }

            return list;
        }

        public List<ElectionDTO> GetEndedElections()
        {
            var list = new List<ElectionDTO>();
            DepartmentService departmentService = new DepartmentService();
                var elections = db.Elections.Include(e => e.Candidates).Include(e => e.Department).Include(e => e.Winners).Where(e => e.EndStatus == true && e.Status == true).ToList();
                foreach (var election in elections)
                {
                    ElectionDTO electionDTO = new ElectionDTO();
                    electionDTO.ElectionId = election.ElectionId;
                    electionDTO.ElectionName = election.ElectionName;
                    electionDTO.Department = election.Department.DepartmentName;
                    electionDTO.Description = election.Description;
                    electionDTO.Candidates = election.Candidates.ToList();
                    electionDTO.Winners = election.Winners.ToList();
                    list.Add(electionDTO);
                }
            return list;
        }
        public Boolean DoesElectionAlreadyExisted(string electionName, int departmentId)
        {
                var election = db.Elections.FirstOrDefault(e => e.ElectionName == electionName || e.DepartmentId == departmentId && e.Status == true);
                if (election == null)
                    return false;
                return true;
        }
        public void UpdateElectionStatus(int electionId)
        {
            var election = db.Elections.FirstOrDefault(e => e.ElectionId == electionId);
            if (election != null)
            {
                election.Status = true;
                db.SaveChanges();
            }
 
        }
        public List<Election> GetActiveElections()
        {
                return db.Elections.Where(e => e.Status == true).ToList();
            
        }
        public List<Election> GetInactiveElections()
        {
                return db.Elections.Where(e => e.Status == false).ToList();
        }
        public void DeleteElection(int electionId)
        {
               db.Candidates.RemoveRange(db.Candidates.Where(c => c.ElectionId == electionId));
                db.Elections.RemoveRange(db.Elections.Where(e => e.ElectionId == electionId));
                db.SaveChanges();
        }
        public bool FindDepartmentActiveElection(int departmentId)
        {
                var hasActiveElection = db.Elections
                    .Any(e => e.DepartmentId == departmentId && e.Status == true);
                return hasActiveElection;  
        }
        public string GetElectionsCount()
        {
                return db.Elections.Count().ToString();
        }
        public void SetEndStatus(int electionId)
        {
            var election = db.Elections.FirstOrDefault(e => e.ElectionId == electionId);
            election.EndStatus = true;
            db.SaveChanges();
        }


    }
}