using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Models;

namespace EmployeeManagement.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employees> GetAll();
        Employees AddEmployee(Models.Employees obj);
        Employees GetEmployeebyId(int id);
        void EditEmployee(Employees obj);
        void DeleteEmployee(int id);
        List<Employees> SearchEmployee(String Obj);
    }
}
