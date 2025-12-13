using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsFormsApp1
{
    internal class PositionService : DBConnection
    {
        public int GetPositionId(string positionName)
        {
            using (var db = new eBotoDBEntities())
            {
                var position = db.Positions.FirstOrDefault(p => p.PositionName == positionName);
                return position != null ? position.PositionId : -1;
            }
        }

        public List<Position> GetAllPositionObjects()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Positions.ToList();
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

        public void SavePosition(string positionName)
        {
            using (var db = new eBotoDBEntities())
            {
                db.Positions.Add(new Position { PositionName = positionName.ToUpper() });
                db.SaveChanges();
            }
        }

        public void DeletePosition(int positionId)
        {
            using (var db = new eBotoDBEntities())
            {
                var position = db.Positions.FirstOrDefault(p => p.PositionId == positionId);
                if (position != null)
                {
                    db.Positions.Remove(position);
                    db.SaveChanges();
                }
            }
        }

        public Boolean DoesExists(string positionName)
        {
            using (var db = new eBotoDBEntities())
            {
                var post = db.Positions.FirstOrDefault(d => d.PositionName == positionName);
                return post != null;
            }
        }

        public void EditPosition(int positionId, string newPosition)
        {
            using (var db = new eBotoDBEntities())
            {
                var checkPos = db.Positions.FirstOrDefault(p => p.PositionName == newPosition && p.PositionId != positionId);
                if (checkPos != null)
                {
                    MessageBox.Show("Department already exists.");
                }else
                {
                    var position = db.Positions.FirstOrDefault(p => p.PositionId == positionId);
                    if (position != null)
                    {
                        position.PositionName = newPosition;
                        db.SaveChanges();
                    }
                }
                
            }
        }

        public void ClearAllPositions()
        {
            using (var db = new eBotoDBEntities())
            {
                var allPositions = db.Positions.ToList();
                db.Positions.RemoveRange(allPositions);
                db.SaveChanges();
            }
        }

        public int GetPositionsCount()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Positions.Count();
            }
        }
    }
}
