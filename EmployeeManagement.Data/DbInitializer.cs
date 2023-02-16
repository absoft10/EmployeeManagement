using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EmployeeDataContext context)
        {
            //// Look for any students.
            if (context.Employees.Any())
            {
                return;   // DB has been seeded
            }

            var EmployeeList = new Employees[]
            {
                new Employees{Name="Ronaldo",Email="Ronaldo@yopmail.com",CreatedOn = DateTime.Parse("2019-09-01"),Department="Portugal",Dob =DateTime.Parse("1991-09-01") },
                new Employees{Name="Messi",Email="Messi@yopmail.com",CreatedOn = DateTime.Parse("2020-09-01"),Department="Argentina",Dob =DateTime.Parse("1992-09-01")},
                 new Employees{Name="Neymar",Email="Neymar@yopmail.com",CreatedOn = DateTime.Parse("2021-09-01"),Department="Brazil",Dob =DateTime.Parse("1993-09-01")},
                  new Employees{Name="Modric",Email="Messi@yopmail.com",CreatedOn = DateTime.Parse("2022-09-01"),Department="Croatia",Dob =DateTime.Parse("1994-09-01")},

            };
             
            context.Employees.AddRange(EmployeeList);
            context.SaveChanges();


        }
    }
}
