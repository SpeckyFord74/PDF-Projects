using System;

namespace Manipulate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter text: ");
            string Text = Console.ReadLine();

            Console.Write($"\nThanks. You entered: {Text}");
            Console.WriteLine($"\n\nText length: {Text.Length}");

            Text = Text.Trim();
            Console.Write($"\nTrimmed:\t{Text.Length}");
            Console.WriteLine($"\tText length: {Text.Length}");

            string Upper = Text.ToUpper();
            Console.WriteLine($"\nUpper case:\t{Upper}");

            string Lower = Text.ToLower();
            Console.WriteLine($"\nLower case:\t{Lower}");

            Upper = Upper.PadLeft(40);
            Lower = Lower.PadRight(40, '#');
            Text = Text.PadLeft(30, '*').PadRight(40, '#');

            Console.WriteLine($"\nPadded left:\t{Upper}");
            Console.WriteLine($"Padded right:\t{Lower}");
            Console.WriteLine($"Padded both:\t{Text}");

            Console.Write($"\nTrimmed start:\t{Upper.TrimStart()}");
            Console.Write($"Trimmed end:\t{Text.TrimEnd()}");

            Console.ReadLine();
        }
    }
}
