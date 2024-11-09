internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("First number:");
        var num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("First number is even");
        }
        else
        {
            Console.WriteLine("First number is odd");
        }
        
    }
}