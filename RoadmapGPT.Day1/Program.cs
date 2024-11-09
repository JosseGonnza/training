using System.Text;

namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] array = [1, 2, 3, 4, 5];
        var target = 6;
        var result = FindPairsToSum(array, target);
        Console.WriteLine(string.Join(",", result));
    }

    private static List<(int, int)> FindPairsToSum(int[] array, int number)
    {
        List<(int, int)> pairs = new List<(int, int)>();
        
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = (i + 1); j < array.Length; j++)
            {
                if ((array[i] + array[j]) == number)
                {
                    pairs.Add((array[i], array[j]));
                }
            }
        }
        return pairs;
    }
}