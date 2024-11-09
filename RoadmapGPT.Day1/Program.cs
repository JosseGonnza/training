namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] array = [1, 2, 3, 4];
        var number = 3;
        Console.WriteLine(FindNumber(array, number));
    }

    private static bool FindNumber(int[] array, int number)
    {
        foreach (var n in array)
        {
            if (n == number) return true;
        }
        return false;
    }
}