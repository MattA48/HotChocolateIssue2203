namespace hotchoctemp
{
    public class QueryImpl : IQueryResult
    {
        public long Hello => 1237682346;

        int IQueryResult.Hello => 123;
    }
}