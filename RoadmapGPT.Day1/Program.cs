namespace RoadmapGPT.Day1;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("First number:");
        var num = Convert.ToInt32(Console.ReadLine());

        /*var i = 0;
    while (i <= 10)
    {
        var product = num * i;
        Console.Write(num + " * " + i + " = " + product);
        Console.Write("\n");
        i++;
    }*/

        for (int j = 0; j < 10; j++)
        {
            var product = num * j;
            Console.Write(num + " * " + j + " = " + product);
            Console.Write("\n");
        }
    }
}