using System;

namespace Joined
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Copied";

            string Car1 = "Ghibli";
            string Car2 = "GranTurismo";

            Console.WriteLine("Original:");
            Console.WriteLine($"\tCar 1: {Car1} \t\tCar 2: {Car2}");

            Car1 = String.Copy(Car2);
            Console.WriteLine("\nCopied:");
            Console.WriteLine($"\tCar 1 : {Car1} \t\tCar 2: {Car2}");

            int Num = Car1.Length;
            char[] Model = new char[Num];

            Car1.CopyTo(0, Model, 0, Num);
            Console.WriteLine("\nCharacter Array:");
            foreach(char C in Model)
            {
                Console.Write($"{C} ");
            }

            Car1 = Car1.Remove(4);
            Console.WriteLine($"\n\nRemoved...\tCar 1: {Car1}");

            Car1 = Car1.Insert(0, "Maserati");
            Car1 = Car1.Insert(13, "Cabrio");
            Console.WriteLine($"\nInserted...\tCar 1: {Car1}");

            Car1 = Car1.Replace("GranCabrio", "Quattroporte");
            Console.WriteLine($"\nReplaced...\tCar 1: {Car1}");

            Console.ReadLine();
        }
    }
}