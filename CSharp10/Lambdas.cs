namespace CSharp10;

public class Lambdas
{
    public void NewLambdaFeatures()
    {
        // Natural types for lambdas
        var parse = (string s) => int.Parse(s);
        int parsedResult = parse.Invoke("2");

        // Natural types for method groups
        var read = Console.Read;
        int result = read.Invoke();
    }
}
