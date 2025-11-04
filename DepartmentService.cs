using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DepartmentService
    {
        public List<string> GetAllDepartments()
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Departments.Select(d => d.DepartmentName).ToList();
            }
        }
        public int GetDepartmentIdByName(string departmentName)
        {
            using (var db = new eBotoDBEntities())
            {
                var department = db.Departments.FirstOrDefault(d => d.DepartmentName == departmentName);
                return department != null ? department.DepartmentId : -1;
            }
        }
        public string GetDepartmentNameById(int departmentId)
        {
            using (var db = new eBotoDBEntities())
            {
                return db.Departments.FirstOrDefault(e => e.DepartmentId == departmentId).DepartmentName;
            }
        }

       
            
    }
}
