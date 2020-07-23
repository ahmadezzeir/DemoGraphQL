using Api.Graph.Types;
using Api.Repositories;
using GraphQL.Types;

namespace Api.Graph
{
    public class ApplicationQuery : ObjectGraphType
    {
        public ApplicationQuery(
            DepartmentRepository departmentRepository,
            EmployeeRepository employeeRepository
            )
        {
            Field<ListGraphType<DepartmentType>>(
                "departments",
                resolve: context => departmentRepository.GetAll()
            );

            Field<ListGraphType<Types.EmployeeType>>(
                "employees",
                resolve: context => employeeRepository.GetAll()
            );
        }
    }
}
