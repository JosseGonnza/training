namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        var result = Sum(5, 7);
        Console.WriteLine(result);
    }

    private static int Sum(int a, int b)
    {
        return a + b;
    }
}