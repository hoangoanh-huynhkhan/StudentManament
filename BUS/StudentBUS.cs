using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS
{
    public class StudentBUS
    {
        public List<Student> GetAll()
        {
            var students = new List<Student>();
            DBContext db = new DBContext();
            
            students = db.Students.Where(x => x.StudentDelete == 0).ToList();
            
            return students;
        }
    }
}
