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
    }
}
