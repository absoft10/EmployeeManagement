using EmployeeManagement.Data;
using EmployeeManagement.Models;
using EmployeeManagement.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositories.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDataContext _context;

        public EmployeeRepository(EmployeeDataContext context)
        {
            _context = context;
        }

        public Employees AddEmployee(Models.Employees obj)
        {
            _context.Employees.Add(obj);
            _context.SaveChanges();

            return obj;
        }

        public void EditEmployee(Employees obj)
        {
            _context.Employees.Update(obj);
            _context.SaveChanges();
        }

        public Employees GetEmployeebyId(int id)
        {
            var Employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            return Employee;
        }



        public List<Employees> GetAll()
        {
            return _context.Employees.ToList(); 
        }

        public void DeleteEmployee(int id)
        {
            var DelObj = _context.Employees.Where(x => x.Id == id).FirstOrDefault();

            if(DelObj != null) 
            {

                _context.Remove(DelObj);
                _context.SaveChanges();

            }


        }

        public List<Employees> SearchEmployee(string Obj)
        {
            var Employees  = _context.Employees.Where(x => x.Name.Contains(Obj) || x.Email.Contains(Obj) || x.Department.Contains(Obj)).ToList();
            return Employees;
        }
    }
}
