using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employees
    {
        public int Id { set; get; }
        public String Name { set; get; }
        public String Email { set; get; }
        public String Department { set; get; }
        public DateTime Dob { set; get; }
        public DateTime CreatedOn { set; get; }
    }
}
