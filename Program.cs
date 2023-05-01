namespace RegelurExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegPatterns regexPattern = new RegPatterns();
            regexPattern.Name();
            regexPattern.Email();
            regexPattern.Phone();
        }
    }
}