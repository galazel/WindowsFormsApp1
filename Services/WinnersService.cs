using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Services
{
    internal class WinnersService : DBConnection
    {
        public List<Winner> GetWinners(int electionId) {        
            return db.Winners.Where(w => w.ElectionId == electionId).OrderBy(w => w.PositionId).ToList();
        }
    }
}
