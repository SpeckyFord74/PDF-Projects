using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");

            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter another number: ");
            double sum =
                num + Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Total: {sum}");

            Console.ReadLine();
        }
    }
}