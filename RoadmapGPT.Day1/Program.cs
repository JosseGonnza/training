using System.Text;

namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        var word = "aaabbcc";
        Console.WriteLine(CompressorString(word));
    }

    private static string CompressorString(string randomWord)
    {
        StringBuilder result = new StringBuilder();
        var sum = 1;

        for (int i = 1; i < randomWord.Length; i++)
        {
            if (randomWord[i] == randomWord[i - 1])
            {
                sum++;
            }
            else
            {
                result.Append(randomWord[i - 1]).Append(sum);
                sum = 1;
            }
        }
        result.Append(randomWord[^1]).Append(sum);
        return result.ToString();
    }
}