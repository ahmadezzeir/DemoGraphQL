using GraphQL.Types;

namespace Api.Graph.EnumTypes
{
    public class EmployeeTypes : EnumerationGraphType<Data.Entities.EmployeeTypes>
    {
        public EmployeeTypes()
        {
            Name = "Type";
            Description = "Employee Type";
        }
    }
}
