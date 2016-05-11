namespace EmployeesRegister.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EmployeesRegister.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeesRegister.DataAccessLayer.EmployeesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeesRegister.DataAccessLayer.EmployeesContext context)
        {
                context.Employees.AddOrUpdate(
                    e => e.FirstName,
                    new Employee()
                    {
                        FirstName = "Kalle",
                        LastName = "Anka",
                        Salary = 100,
                        Position = "Janitor",
                        Department = "Quackdepartment",
                        Company = "Acme Inc"
                    },
                    new Employee()
                    {
                       FirstName = "Joakim",
                       LastName = "von Anka",
                       Salary = 300,
                       Position = "President",
                       Department = "Quackdepartment",
                       Company = "NK"
                    },
                    new Employee()
                    {
                       FirstName = "Kajsa",
                       LastName = "Anka",
                       Salary = 120,
                       Position = "Manager",
                       Department = "Quackdepartment",
                       Company = "EPA"
                    });
                
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
