using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EverisTest2015.Models
{
    public class Skill
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<EmployeesSkills> Employees { get; set; }
    }
}