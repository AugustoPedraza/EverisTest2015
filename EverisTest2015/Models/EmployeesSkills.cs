using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EverisTest2015.Models
{
    public enum Experience
    {
        None,
        Basic,
        Intermediate,
        Advanced,
        Expert
    }
    
    public class EmployeesSkills
    {
        public int Id { get; set; }
        
        public virtual int SkillId { get; set; }
        public virtual int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Skill Skill { get; set; }

        public Experience Experience { get; set; }
    }
}
