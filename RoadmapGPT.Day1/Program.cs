namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        var number = 1221;
        Console.WriteLine(IsPalindrome(number));
    }

    private static bool IsPalindrome(int number)
    {
        var original = number;
        var reverse = 0;
        while (number > 0)
        {
            var digit = number % 10;
            reverse = reverse * 10 + digit;
            number /= 10;
        }

        return original == reverse;
    }
}