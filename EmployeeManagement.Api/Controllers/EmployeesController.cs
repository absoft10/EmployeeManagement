using EmployeeManagement.Models;
using EmployeeManagement.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        
        private readonly IEmployeeRepository _repository;
        public EmployeesController( IEmployeeRepository repository)
        {
            
            _repository = repository;
        }

        // GET: api/<EmployeesController>
        [HttpGet]
        public IEnumerable<Employees> GetAll()
        {
            var list = _repository.GetAll().ToArray();
            return list;
             
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public Employees Get(int id)
        {
            var Emp = _repository.GetEmployeebyId(id);
            return Emp;

        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] Employees employees)
        {
            //Employees employees1 = new Employees();
            //employees1.Name = employees.Name;  
            //employees1.Email = employees.Email;
            //employees1.Dob = Convert.ToDateTime(employees.Dob);
            //employees1.Department = employees.Department;
            //employees1.CreatedOn = Convert.ToDateTime(employees.CreatedOn);

            _repository.AddEmployee(employees);
             
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employees employees)
        {
            Employees employeetoupdate = _repository.GetEmployeebyId(id);
            employeetoupdate.Email = employees.Email;
            employeetoupdate.Name = employees.Name;
            employeetoupdate.Department = employees.Department;
            employeetoupdate.Id = id;
            employeetoupdate.Dob = employees.Dob;
            _repository.EditEmployee(employeetoupdate);


        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.DeleteEmployee(id);
        }
    }
}
