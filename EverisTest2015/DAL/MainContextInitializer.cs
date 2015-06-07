using EverisTest2015.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EverisTest2015.DAL
{
    public class MainContextInitializer : DropCreateDatabaseIfModelChanges<MainContext>
    {
        protected override void Seed(MainContext context)
        {
            var employees = new List<Employee>
            {
                new Employee {EmployeeId = 1234, FullName = "Fake1" },
                new Employee {EmployeeId = 2345, FullName = "Fake2" },
                new Employee {EmployeeId = 3456, FullName = "Fake3" }
            };

            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();
        }
    }
}
