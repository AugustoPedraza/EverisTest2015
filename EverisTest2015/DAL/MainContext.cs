using EverisTest2015.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EverisTest2015.DAL
{
    public class MainContext: DbContext
    {
        public MainContext()
            : base("SQLAzureConnection")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeesSkills> EmployeesSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Employee>()
               .HasKey(e => new { e.ID });

            modelBuilder.Entity<Employee>()
                        .HasMany(e => e.Skills)
                        .WithRequired()
                        .HasForeignKey(es => es.EmployeeId);



            modelBuilder.Entity<Skill>()
                        .HasMany(e => e.Employees)
                        .WithRequired()
                        .HasForeignKey(es => es.SkillId);

            modelBuilder.Entity<Skill>().HasKey(s => s.ID);
            
            
            modelBuilder.Entity<EmployeesSkills>().HasKey(es => es.Id);
        }
    }
}