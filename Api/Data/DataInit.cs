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
            }
        }

    }
}
