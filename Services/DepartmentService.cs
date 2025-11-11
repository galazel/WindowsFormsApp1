using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DepartmentService : DBConnection
    {
        public List<string> GetAllDepartments()
        {
                return db.Departments.Select(d => d.DepartmentName).ToList();
        }
        public int GetDepartmentIdByName(string departmentName)
        {
                var department = db.Departments.FirstOrDefault(d => d.DepartmentName == departmentName);
                return department != null ? department.DepartmentId : -1;
        }
        public string GetDepartmentNameById(int departmentId)
        {
                return db.Departments.FirstOrDefault(e => e.DepartmentId == departmentId).DepartmentName;
        }
        public void SaveDepartment(string departmentName)
        {
                db.Departments.Add(new Department { DepartmentName = departmentName.ToUpper() });
                db.SaveChanges();
        }
        public void DeleteDepartment(int departmentId)
        {
                var department = db.Departments.FirstOrDefault(d => d.DepartmentId == departmentId);
                db.Departments.Remove(department);
                db.SaveChanges();
        }

        public Boolean DoesExists(string department)
        {
                var dept = db.Departments.FirstOrDefault(d => d.DepartmentName == department);
                if(dept == null)
                    return false;
            return true;
        }

        public void EditDepartment(int departmentId, string newDepartment)
        {
            var department = db.Departments.FirstOrDefault(p => p.DepartmentId == departmentId);
            if (department == null) return;
            else department.DepartmentName = newDepartment;

            db.SaveChanges();
        }



    }
}
