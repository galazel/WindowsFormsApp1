using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Others
    {
       public String CandidateName { get; set; }
        public String Partylist { get; set; }
        public String Motto { get; set; }
        public String Image { get; set; }
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
       
        public static List<Others> othersList = new List<Others>();

    }
}
