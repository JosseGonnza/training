internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Introduce el primer numero");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el segundo numero");
        int number2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("\n");
        
        var sum = number1 + number2;
        var rest = number1 - number2;
        var product = number1 * number2;
        var division = ((double)number1 / number2);
        
        Console.WriteLine("La suma de los numeros es: " + sum);
        Console.WriteLine("La resta de los numeros es: " + rest);
        Console.WriteLine("La multiplicacion de los numeros es: " + product);
        Console.WriteLine("La division de los numeros es: " + division);
    }
}