namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escribe algo bonito: ");
        var phrase = Convert.ToString(Console.ReadLine());
        var result = VocalCount(phrase);
        
        Console.WriteLine("Hay un total de " + result + " vocales.");
    }

    private static int VocalCount(string phrase)
    {
        int vocalCount = 0;
        var vocals = "aeiouAEIOU";

        foreach (char c in phrase)
        {
            if (vocals.Contains(c)) vocalCount++;
        }
        return vocalCount;
    }
}