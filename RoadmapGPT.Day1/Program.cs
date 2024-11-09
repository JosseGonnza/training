namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        var phrase = "Anita lava la tina";
        Console.WriteLine(IsPalindrome(phrase));
    }

    private static bool IsPalindrome(string phrase)
    {
        var newPhrase = phrase.ToLower().Replace(" ", "");
        var charArray = newPhrase.ToCharArray();
        Array.Reverse(charArray);
        var phraseReverse = new string(charArray);

        return newPhrase == phraseReverse;
    }
}