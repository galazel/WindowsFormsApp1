using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1.Services
{
    internal class WinnersService : DBConnection
    {
        public List<Winner> GetWinners(int electionId)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Winners
                         .Where(w => w.ElectionId == electionId)
                         .OrderBy(w => w.PositionId)
                         .ToList();
            }
        }

        public void ClearAll()
        {
            using (var db = new eBotoDBEntities())
            {
                var allWinners = db.Winners.ToList();
                db.Winners.RemoveRange(allWinners);
                db.SaveChanges();
            }
        }

        public int WinnersCount()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Winners.Count();
            }
        }

        public void ClearAllWinners()
        {
            using (var db = new eBotoDBEntities())
            {
                var allWinners = db.Winners.ToList();
                db.Winners.RemoveRange(allWinners);
                db.SaveChanges();
            }
        }
    }
}
