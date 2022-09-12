using System;

namespace Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cast";

            double num = 10.5;
            int integer = 2;

            num = num + integer;
            Console.WriteLine($"Implicit cast: {num}");

            num = (double) 7 / integer;
            Console.WriteLine($"Explicit cast: {num}");

            char letter = (char) 65;
            Console.WriteLine($"Cast integer: {letter}");

            int ascii = (int)'A';
            Console.WriteLine($"Cast letter: {ascii}");

            Console.ReadLine();
        }
    }
}