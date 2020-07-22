using Api.Data.Entities;
using System;
using System.Linq;

namespace Api.Data
{
    public static class DataInit
    {
        public static void Seed(this ApplicationDbContext dbContext)
        {
            if (!dbContext.Departments.Any())
            {
                dbContext.Departments.Add(new Department
                {
                    Name = "HR",
                    //Id = 1,
                    Created = DateTime.Now,
                    CreatedBy = "Ahmad"
                });
                dbContext.Departments.Add(new Department
                {
                    Name = "ICT",
                    //Id = 2,
                    Created = DateTime.Now,
                    CreatedBy = "Ahmad"
                });
                dbContext.SaveChanges();

                dbContext.Employees.Add(new Employee
                {
                    Name = "Employee1",
                    //Id = 1,
                    Created = DateTime.Now,
                    CreatedBy = "Ahmad",
                    DepartmentId = 1
                });
                dbContext.Employees.Add(new Employee
                {
                    Name = "Employee2",
                    //Id = 1,
                    Created = DateTime.Now,
                    CreatedBy = "Ahmad",
                    DepartmentId = 1
                });
                dbContext.Employees.Add(new Employee
                {
                    Name = "Employee3",
                    //Id = 1,
                    Created = DateTime.Now,
                    CreatedBy = "Ahmad",
                    DepartmentId = 2
                });
                dbContext.Employees.Add(new Employee
                {
                    Name = "Employee4",
                    //Id = 1,
                    Created = DateTime.Now,
                    CreatedBy = "Ahmad",
                    DepartmentId = 2
                });
                dbContext.Employees.Add(new Employee
                {
                    Name = "Employee5",
                    //Id = 1,
                    Created = DateTime.Now,
                    CreatedBy = "Ahmad",
                    DepartmentId = 2
                });
                dbContext.Employees.Add(new Employee
                {
                    Name = "Employee6",
                    //Id = 1,
                    Created = DateTime.Now,
                    CreatedBy = "Ahmad",
                    DepartmentId = 2
                });

                dbContext.SaveChanges();
            }
        }

    }
}
