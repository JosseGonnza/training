namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        int[,] year = new int[,]{{1, 2, 3}, {4, 5, 6}, {7, 8 ,9}};
        Console.WriteLine(SumDiagonalOfMatriz(year));
    }

    private static int SumDiagonalOfMatriz(int[,] matriz)
    {
        var longitude = matriz.GetLength(0);
        var sum = 0;
        for (int i = 0; i < longitude; i++)
        {
            sum += matriz[i, i];
        }
        return sum;
    }
}