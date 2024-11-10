namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        var year = 1916;
        Console.WriteLine(IsLeap(year));
    }

    private static bool IsLeap(int year)
    {
        if (year % 400 != 0 && year % 100 == 0 || year % 4 != 0)
        {
            return false;
        }
        return true;
    }
}