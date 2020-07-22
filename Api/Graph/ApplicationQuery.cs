using Api.Graph.Types;
using Api.Repositories;
using GraphQL.Types;

namespace Api.Graph
{
    public class ApplicationQuery : ObjectGraphType
    {
        public ApplicationQuery(DepartmentRepository departmentRepository)
        {
            Field<ListGraphType<DepartmentType>>(
                "departments",
                resolve: context => departmentRepository.GetAll()
            );
        }
    }
}
