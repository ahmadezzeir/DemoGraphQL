using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Entities;
using GraphQL.Types;

namespace Api.Graph.Types
{
    public class EmployeeType : ObjectGraphType<Employee>
    {
        public EmployeeType()
        {
            Field(t => t.Id);
            Field(t => t.Name).Description("The name of the employee");
            Field(t => t.Created);
            Field(t => t.CreatedBy);//.Description("When the product was first introduced in the catalog");
            //Field(t => t.Updated,true);//.Description("The file name of the photo so the client can render it");
            Field(t => t.UpdatedBy);
            //Field<EnumTypes.EmployeeTypes>("EmployeeType", "Employee Type");
        }
    }
}
