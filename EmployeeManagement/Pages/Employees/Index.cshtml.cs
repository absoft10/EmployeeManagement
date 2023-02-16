using EmployeeManagement.Models;
using EmployeeManagement.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepository _repository;

        public IndexModel(IEmployeeRepository repository)
        {
            _repository = repository;

        }

        public List<Models.Employees> EmployeesList { set;get;}

        public void OnGet()
        {
            EmployeesList = _repository.GetAll();
        }

     



        //Deleting the EmployeeObj
        //public IActionResult OnPost(int Id)
        //{
        //    _repository.DeleteEmployee(Id);

        //  return  RedirectToPage("/Employees/Index");
        //}
    }
}
