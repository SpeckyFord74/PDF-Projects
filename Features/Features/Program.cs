using System;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter text: ");
                string Text = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(Text))
                {
                    Console.WriteLine("\nERROR:No Text Found!");
                }

                else
                {
                    Console.WriteLine($"\nThanks. You entered:\n{Text}");
                    Console.WriteLine($"\nText Length: {Text.Length}");

                    string Query = Text.StartsWith("C#") ? "does" : "does not";
                    Console.WriteLine($"Text {Query} start with 'C#'");

                    Query = Text.EndsWith("steps") ? "does" : "does not";
                    Console.WriteLine($"Text {Query} end with 'steps'");

                    Query = Text.Contains("easy") ? "does" : "does not";
                    Console.WriteLine($"Text {Query} include 'easy'");
                }
                
                if(Text == "Exit Program")
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}