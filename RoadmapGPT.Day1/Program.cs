namespace RoadmapGPT.Day1;

internal class Program
{
    public static void Main(string[] args)
    {
        int[,] matriz = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        var result = RotateMatriz(matriz);
        PrintMatriz(matriz);
        Console.WriteLine("\n");
        PrintMatriz(result);
    }

    private static int[,] RotateMatriz(int[,] matriz)
    {
        var longitude = matriz.GetLength(0);
        int[,] rotate = new int[longitude, longitude];
        
        for (int i = 0; i < longitude; i++)
        {
            for (int j = 0; j < longitude; j++)
            {
                rotate[j, longitude - i - 1] = matriz[i, j];
            }
        }
        return rotate;
    }
    
    private static void PrintMatriz(int[,] matriz)
    {
        int rows = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matriz[i, j]); 
            }
            Console.WriteLine(); 
        }
    }
}