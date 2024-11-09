namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        var phrase = "ana";
        var result = StringReverse(phrase);
        Console.WriteLine(result);
    }

    private static string StringReverse(string phrase)
    {
        var charArray = phrase.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}