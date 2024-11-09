namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        var pairs = PairFilter(numbers);
        Console.WriteLine(string.Join(",", pairs));
    }

    private static int[] PairFilter(int[] array)
    {
        List<int> pairs = new List<int>();
        foreach (var num in array)
        {
            if (num % 2 == 0) pairs.Add(num);
        }
        return pairs.ToArray();
    }
}