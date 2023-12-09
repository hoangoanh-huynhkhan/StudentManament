using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BUS
{
    public class FacultyBUS
    {
        public List<Faculty> GetAll()
        {
            var faculties = new List<Faculty>();
            using(DBContext db = new DBContext())
            {
                faculties = db.Faculties.Where(x => x.FacultyDelete == 0).ToList();
            }
            return faculties;
        }
    }
}
