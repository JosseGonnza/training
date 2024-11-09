namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine(SumDiagonals(matriz));
    }

    private static int SumDiagonals(int[,] matriz)
    {
        int sum = 0;
        int longitude = matriz.GetLength(0);

        for (int i = 0; i < longitude; i++)
        {
            sum += matriz[i, i];
            sum += matriz[i, (longitude - i - 1)];
        }

        return sum;
    }
}