namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = [1, 2, 3, 4, 5];
        var result = ElementSum(numbers);
        
        Console.WriteLine(result);
    }

    private static int ElementSum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i <= (array.Length -1); i++)
        {
            sum += array[i];
        }
        return sum;
    }
}