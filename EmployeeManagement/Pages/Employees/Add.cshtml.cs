using EmployeeManagement.Models;
using EmployeeManagement.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement.Pages.Employees
{
    public class AddModel : PageModel
    {
        private readonly IEmployeeRepository _repository;

        public AddModel(IEmployeeRepository repository)
        {
            _repository = repository;

        }
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string EmailAddress { get; set; }

        [BindProperty]
        public string Department { get; set; }

        [BindProperty]
        public DateTime Dob { get; set; }


        public void OnGet()
        {
        }
        

        public IActionResult OnPost() 
        {
            Models.Employees obj = new Models.Employees();
            obj.Email = EmailAddress;
            obj.Name = Name;
            obj.Dob = Dob;
            obj.Department = Department;
            obj.CreatedOn = DateTime.Now;


            var added=_repository.AddEmployee(obj);

            return new RedirectToPageResult("/Employees/Index");

        }
    }
}
