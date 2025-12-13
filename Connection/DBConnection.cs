using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class DBConnection:IDisposable
    {
        protected readonly eBotoDBEntities db;

        public DBConnection()
        {
            db = new eBotoDBEntities();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
