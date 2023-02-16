using EmployeeManagement.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.Emit;

namespace EmployeeManagement.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository _repository;

        public EditModel(IEmployeeRepository repository)
        {
            _repository = repository;

        }
        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string EmailAddress { get; set; }

        [BindProperty]
        public string Department { get; set; }

        [BindProperty]
        public DateTime Dob { get; set; }

        public void OnGet(int Id)
        {
            var RecordToEdit = _repository.GetEmployeebyId(Id);

            Name = RecordToEdit.Name;
            EmailAddress = RecordToEdit.Email;
            Department = RecordToEdit.Department;
            Dob = RecordToEdit.Dob;
            Id = RecordToEdit.Id;
        }


        public IActionResult OnPost()
        {
            Models.Employees obj = new Models.Employees();
            obj.Email = EmailAddress;
            obj.Name = Name;
            obj.Dob = Dob;
            obj.Department = Department;
            obj.CreatedOn = DateTime.Now;
            obj.Id = Id;

            _repository.EditEmployee(obj);

            return new RedirectToPageResult("/Employees/Index");

        }
    }
}
