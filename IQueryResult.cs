using HotChocolate.Types;

namespace hotchoctemp
{
    [InterfaceType(Name = "QueryResult")]
        public interface IQueryResult
    {
         public int Hello {get;}
    }
}