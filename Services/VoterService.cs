using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    internal class VoterService : DBConnection
    {
        public Boolean AddVoter(Voter voter)
        {
            using (var db = new eBotoDBEntities())
            {
                var existingVoter = db.Voters.FirstOrDefault(v =>
                    v.FirstName == voter.FirstName &&
                    v.LastName == voter.LastName &&
                    v.DepartmentId == voter.DepartmentId &&
                    v.BirthDate == voter.BirthDate);

                if (existingVoter != null)
                    return false;

                db.Voters.Add(voter);
                db.SaveChanges();
                return true;
            }
        }

        public Boolean UpdateVoter(Voter voter)
        {
            using (var db = new eBotoDBEntities())
            {
                var existingVoter = db.Voters.Find(voter.VoterId);
                if (existingVoter == null)
                    return false;

                existingVoter.FirstName = voter.FirstName;
                existingVoter.LastName = voter.LastName;
                existingVoter.MiddleName = voter.MiddleName;
                existingVoter.DepartmentId = voter.DepartmentId;
                existingVoter.Year = voter.Year;
                existingVoter.Section = voter.Section;
                existingVoter.BirthDate = voter.BirthDate;
                existingVoter.ContactNumber = voter.ContactNumber;
                existingVoter.Email = voter.Email;
                existingVoter.Username = voter.Username;
                existingVoter.Password = voter.Password;
                existingVoter.Image = voter.Image;
                existingVoter.Status = voter.Status;

                db.SaveChanges();
                return true;
            }
        }

        public int GetVoterIdByUsername(string username)
        {
            using (var db = new eBotoDBEntities())
            {
                var voter = db.Voters.FirstOrDefault(v => v.Username == username);
                return voter != null ? voter.VoterId : -1;
            }
        }

        public Boolean DoesVoterAlreadyExisted(Voter voter)
        {
            using (var db = new eBotoDBEntities())
            {
                var vot = db.Voters.FirstOrDefault(v =>
                    (v.FirstName == voter.FirstName && v.LastName == voter.LastName) ||
                    (v.Username == voter.Username && v.Password == voter.Password));

                return vot != null;
            }
        }

        public Boolean DoesVoterAlreadyExisted(string username, string password)
        {
            using (var db = new eBotoDBEntities())
            {
                var vot = db.Voters.FirstOrDefault(v => v.Username == username);
                if (vot == null)
                    return false;

                return PasswordHasher.Verify(password, vot.Password);
            }
        }

        public VoterDTO GetVoterDepartment(int voterId)
        {
            using (var db = new eBotoDBEntities())
            {
                var voter = from v in db.Voters
                            join d in db.Departments on v.DepartmentId equals d.DepartmentId
                            where v.VoterId == voterId
                            select new VoterDTO
                            {
                                Voter = v,
                                Department = d,
                                Election = null
                            };
                return voter.FirstOrDefault();
            }
        }

        public VoterDTO GetVoterDepartmentElection(int voterId)
        {
            using (var db = new eBotoDBEntities())
            {
                var voter = from v in db.Voters
                            join d in db.Departments on v.DepartmentId equals d.DepartmentId
                            join e in db.Elections on d.DepartmentId equals e.DepartmentId
                            join c in db.Candidates on e.ElectionId equals c.ElectionId
                            where v.VoterId == voterId && e.Status && !e.EndStatus
                            select new VoterDTO
                            {
                                Voter = v,
                                Department = d,
                                Election = e,
                                Candidates = e.Candidates.ToList(),
                                Positions = e.Candidates
                                    .Where(ca => ca.ElectionId == e.ElectionId)
                                    .Select(ca => ca.Position)
                                    .Distinct()
                                    .ToList()
                            };
                return voter.FirstOrDefault();
            }
        }

        public void SetVoterStatus(int voterId)
        {
            using (var db = new eBotoDBEntities())
            {
                var voter = db.Voters.FirstOrDefault(v => v.VoterId == voterId);
                if (voter != null)
                {
                    voter.Status = true;
                    db.SaveChanges();
                }
            }
        }

        public string GetVotersCount()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Voters.Count().ToString();
            }
        }

        public int GetVotersCountInt()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Voters.Count();
            }
        }

        public string GetVotedCount()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Voters.Count(v => v.Status).ToString();
            }
        }

        public void SetAllVotersStatusInDepartment(int departmentId)
        {
            using (var db = new eBotoDBEntities())
            {
                var voters = db.Voters.Where(v => v.DepartmentId == departmentId);
                foreach (var voter in voters)
                    voter.Status = false;

                db.SaveChanges();
            }
        }

        public void ClearAllVoters()
        {
            using (var db = new eBotoDBEntities())
            {
                var allVoters = db.Voters.ToList();
                db.Voters.RemoveRange(allVoters);
                db.SaveChanges();
            }
        }

        public List<Voter> GetAllVoters()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Voters.ToList();
            }
        }
    }
}
