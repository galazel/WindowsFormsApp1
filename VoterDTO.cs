using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class VoterDTO
    {
        public Voter Voter { get; set; }
        public Department Department { get; set; }
        public Election Election { get; set; }
        public List <Candidate> Candidates { get; set; }
    }
}
