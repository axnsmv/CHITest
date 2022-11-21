namespace CHITest;

internal static class Program
{
    private static void Main()
    {
        using var parser = new Parser(new LoadConfig());
        Console.WriteLine(parser.SumProp(923451, "М", "Д"));
    }
}