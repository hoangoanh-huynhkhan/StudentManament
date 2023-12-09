using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
namespace BUS
{
    public class EmployerBUS
    {
        public List<Employer> GetAll()
        {
            var employers = new List<Employer>();
            using (DBContext db = new DBContext())
            {
                employers = db.Employers.Where(x => x.EmployerDelete == 0).ToList();
            }

            return employers;
        }

        
    }
}
