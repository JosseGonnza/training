namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        var word = "reconocer";
        Console.WriteLine(IsPalindrome(word));
    }

    private static bool IsPalindrome(string word)
    {
        /*var result = string.Join("", word.ToCharArray().Reverse());
        return word == result;*/
        var charArray = word.ToCharArray();
        var result = "";
        for (int i = (word.Length - 1); i >= 0; i--)
        {
            result += word[i];
        }

        return word == result;
    }
}