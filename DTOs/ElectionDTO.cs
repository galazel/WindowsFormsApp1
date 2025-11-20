using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ElectionDTO
    {
        public int ElectionId { get; set; } 
        public string ElectionName { get; set; }
        public string Department {  get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public List <Candidate> Candidates { get; set; }
        public List <Winner> Winners { get; set; }

        public List<Position> Positions { get; set; }
    }
}
