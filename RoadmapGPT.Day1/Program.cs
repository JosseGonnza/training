namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] nums = [5, 10, 15, 30];
        Console.WriteLine(CalculateAverage(nums));
    }

    private static int CalculateAverage(int[] array)
    {
        var sum = 0;
        for (int i = 0; i <= (array.Length - 1); i++)
        {
            sum += array[i];
        }
        var average = sum / array.Length;
        return average;        
    }
}