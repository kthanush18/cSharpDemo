using System;

namespace cSharpDemo
{
    public class ExceptionsDemo
    {
        public static void Main(string[] args)
        {
            int a = 10, b;
            try
            {
                Console.WriteLine("enter a number");
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Invalid operations. Division by zero!");
            }
            finally
            {
                Console.WriteLine("Finally!");
            }

            Console.WriteLine("The End");
        }
    }
}
