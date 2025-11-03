using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class PositionService
    {
        public int GetPositionId(string positionName)
        {
            using (var db = new eBotoDBEntities())
            {
                var position = db.Positions.FirstOrDefault(p => p.PositionName == positionName);
                return position != null ? position.PositionId : -1;
            }
        }
        public string GetPositionName(int positionId)
        {
            using (var db = new eBotoDBEntities())
            {
                var position = db.Positions.FirstOrDefault(p => p.PositionId == positionId);
                return position != null ? position.PositionName : null;
            }
        }
        public List<string> GetAllPositions()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Positions.Select(p => p.PositionName).ToList();
            }
        }
    }
}
