using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class PositionService : DBConnection
    {
        public int GetPositionId(string positionName)
        {
                var position = db.Positions.FirstOrDefault(p => p.PositionName == positionName);
                return position != null ? position.PositionId : -1;
        }
        public string GetPositionName(int positionId)
        {
                var position = db.Positions.FirstOrDefault(p => p.PositionId == positionId);
                return position != null ? position.PositionName : null;
        }
        public List<string> GetAllPositions()
        {
                return db.Positions.Select(p => p.PositionName).ToList();
        }
        public void SavePosition(string positionName)
        {
                db.Positions.Add(new Position { PositionName = positionName.ToUpper() });
                db.SaveChanges();
        }

        public void DeletePosition(int positionId)
        {
                var position = db.Positions.FirstOrDefault(p => p.PositionId == positionId);
                db.Positions.Remove(position);
                db.SaveChanges();
        }
        public Boolean DoesExists(string positionName)
        {
                var post = db.Positions.FirstOrDefault(d => d.PositionName == positionName);
                if (post == null)
                    return false;
            return true;
        }
        public void EditPosition(int positionId, string newPosition)
        {
                var position = db.Positions.FirstOrDefault(p => p.PositionId == positionId);
                if (position == null) return;
                else position.PositionName = newPosition;

                db.SaveChanges();
        }
        public void ClearAllPositions()
        {
            var allPositions = db.Positions.ToList();
            db.Positions.RemoveRange(allPositions);
            db.SaveChanges();
        }
        public int GetPositionsCount()
        {
            return db.Positions.Count();
        }


    }
}
