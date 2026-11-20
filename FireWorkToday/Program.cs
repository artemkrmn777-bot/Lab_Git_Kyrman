using System;
public class Program
{
    public static void Main(string[] args)
    {
 
        double product = 1.0;
        double x = 0.1;
        
        do
        {
            product *= (1.0 + Math.Sin(x));
            x += 0.1;
            x = Math.Round(x, 2); 

            Console.WriteLine("Current x: " + x);
            Console.WriteLine("Current product: " + product);
        } while (x <= 10.0);

        //завдання 56
        Console.WriteLine($"Final Product:  {product: F2}");
    }
}