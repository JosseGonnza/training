namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Introduce una temperatura en celsius: ");
        int temperature = Convert.ToInt32(Console.ReadLine());
        var result = ConvertToFahrenheit(temperature);
        Console.WriteLine("La temperatura en farenheit es: " + result);
    }

    private static int ConvertToFahrenheit(int celsius)
    {
        var result = celsius * 9 / 5 + 32;
        return result;
    }
}