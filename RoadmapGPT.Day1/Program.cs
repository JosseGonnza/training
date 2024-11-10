namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[]{3, 1, 4, 1, 5, 9, 2};
        Console.WriteLine(FindMaxAndMin(array));
    }

    private static (int, int) FindMaxAndMin(int[] array)
    {
        var max = array[0];
        var min = array[0];

        foreach (var num in array)
        {
            if (max < num) max = num;
            if (min > num) min = num;
        }

        return (min, max);
    }
}