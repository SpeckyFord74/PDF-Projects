using System;

namespace For_Each
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "For Each";

            string[] websites = new string[5] { "Google", "YouTube", "Facebook", "Twitter", "Quora" };

            Console.WriteLine("Popular Websites...");

            int rank = 1;
            foreach(string site in websites)
            {
                Console.WriteLine($"Position: {rank} \t{site}");
                rank++;
            }

            Console.ReadKey();
        }
    }
}