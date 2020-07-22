using GraphQL;
using GraphQL.Types;

namespace Api.Graph
{
    public class ApplicationSchema : Schema
    {
        public ApplicationSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<ApplicationQuery>();
        }
    }
}
