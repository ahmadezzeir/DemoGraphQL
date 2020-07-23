using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public EmployeeTypes EmployeeType { get; set; }
    }

    public enum EmployeeTypes
    {
         Type1
        ,Type2
        ,Type3

    }
}
