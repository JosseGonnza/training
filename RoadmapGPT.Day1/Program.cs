namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        var phrase = "Esto es un ejemplo un poco más largo";
        Console.WriteLine(WordCount(phrase));
    }

    private static int WordCount(string phrase)
    {
        var words = phrase.Split(' ');
        var numberOfWords = words.Length;
        return numberOfWords;
    }
}