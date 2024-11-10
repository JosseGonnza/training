namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] array = new[] { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine(CountPairs(array));
    }

    private static int CountPairs(int[] array)
    {
        var pairs = 0;
        foreach (var num in array)
        {
            if (num % 2 == 0)
            {
                pairs++;
            }
        }
        return pairs;
    }
}