namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 12, 5, 74, 6, 9, 100, 83, 3};
        (var max, var min) = FindMaxAndMin(numbers);
        Console.WriteLine($"El número máximo es {max} y el mínimo es {min}");
    }

    private static (int, int) FindMaxAndMin(int[] array)
    {
        var max = array[0];
        var min = array[0];

        foreach (var num in array)
        {
            if (num > max) max = num;
            if (num < min) min = num;
        }
        return (max, min);
    }    
}