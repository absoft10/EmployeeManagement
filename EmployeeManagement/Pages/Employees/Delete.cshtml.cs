using EmployeeManagement.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement.Pages.Employees
{
    public class DeleteModel : PageModel
    {
        private readonly IEmployeeRepository _repository;

        public DeleteModel(IEmployeeRepository repository)
        {
            _repository = repository;

        }
        public IActionResult OnGet(int Id)
        {
            _repository.DeleteEmployee(Id);

          return RedirectToPage("/Employees/Index");
        }
    }
}
