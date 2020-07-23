using Api.Data.Entities;
using GraphQL.Types;

namespace Api.Graph.Enums
{
    public class EmployeeTypeEunm : EnumerationGraphType<EmployeeTypes>
    {
        public EmployeeTypeEunm()
        {
            Name = "Type";
            Description = "The type of employee";
        }
    }
}
