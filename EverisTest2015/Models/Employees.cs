using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EverisTest2015.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public int EmployeeId { get; set; }
        
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Dni { get; set; }
        
        public virtual ICollection<EmployeesSkills> Skills { get; set; }
    }
}