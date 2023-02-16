using EmployeeManagement.Models;
using EmployeeManagement.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeManagement.Pages.Employees
{
    public class SearchModel : PageModel
    {
        private readonly IEmployeeRepository _repository;

        public SearchModel(IEmployeeRepository repository)
        {
            _repository = repository;

        }
        [BindProperty]
        public string Query { get; set; }

        [BindProperty]
        public List<Models.Employees> SearchResult { get; set; }

        public void OnGet()
        {
        }

        public void OnPost() 
        {
            SearchResult = _repository.SearchEmployee(Query);

        }
    }
}
