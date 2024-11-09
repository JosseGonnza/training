internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("First number:");
        var num = Convert.ToInt32(Console.ReadLine());

        var sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum += i;
        }
        
        Console.WriteLine("The sum of this numbers is: " + sum);
    }
}