using System.Xml;

namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Intruce one number:");
        var number = Convert.ToInt32(Console.ReadLine());

        var result = IsPrimeNumber(number);
        
        Console.WriteLine(result);
    }

    private static bool IsPrimeNumber(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}