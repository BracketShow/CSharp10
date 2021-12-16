using System;

namespace CSharpBefore10
{
    public class Lambdas
    {
        public void NewLambdaFeatures()
        {
            // Natural types for lambdas
            Func<string, int> parse = (string s) => int.Parse(s);
            int parsedResult = parse.Invoke("2");

            // Natural types for method groups
            var read = Console.Read;
        }
    }
}
