internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("First number:");
        var num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Second number:");
        var num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2)
        {
            Console.WriteLine("Both numbers are equal");
        }
        else if (num1 > num2)
        {
            Console.WriteLine("First number is greater than second number");     
        }
        else
        {
            Console.WriteLine("Second number is greater than first number");
        }
    }
}