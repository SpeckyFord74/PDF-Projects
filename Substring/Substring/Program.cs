using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = "My dog is a cute dog";
            Console.WriteLine($"{Text}\tLength: {Text.Length}");

            Console.WriteLine("\nPlease enter a substring to seek: ");
            string Sub = Console.ReadLine();

            char[] arr = new char[Sub.Length];
            Sub.CopyTo(0, arr, 0, Sub.Length);

            int Pos = Text.IndexOf(Sub);
            Report(Pos, Sub);

            Pos = Text.LastIndexOf(Sub);
            Report(Pos, Sub);

            Pos = Text.IndexOfAny(arr);
            Report(Pos, Text.Substring(Pos, 1));

            Pos = Text.LastIndexOfAny(arr);
            Report(Pos, Text.Substring(Pos, 1));

            Console.ReadLine();
        }

        static void Report(int Pos, string Sub)
        {
            if (Pos != -1)
            {
                Console.WriteLine($"'{Sub}' Found at {Pos}");
            }
            else
            {
                Console.WriteLine($"'{Sub}' Not found!");
            }
        }
    }
}