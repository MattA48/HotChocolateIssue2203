using HotChocolate.Types;

namespace hotchoctemp
{
 [ExtendObjectType(Name = "Query")]
    public class TempQueries
    {
        public IQueryResult Test()
        {
            return new QueryImpl();
        }
    }

}
