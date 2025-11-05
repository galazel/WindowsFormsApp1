using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsFormsApp1
{
    internal class VoterService
    {
        public void AddVoter(Voter voter)
        {
            using (var db = new eBotoDBEntities())
            {
                var existingVoter = db.Voters.FirstOrDefault(v => v.VoterId == voter.VoterId);
                if(existingVoter == null)
                {
                    db.Voters.Add(voter);
                    db.SaveChanges();
                }else
                {
                    MessageBox.Show("Voter already exists!");
                    return;
                }

               
            }
        }
    }
}
