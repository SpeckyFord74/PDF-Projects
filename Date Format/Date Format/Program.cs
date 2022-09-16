using System;

namespace Date_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Date Format";

            DateTime Now = DateTime.Now;
            Console.Write($"Current date and time: {Now}");

            Console.Write($"\nDay name: {Now.DayOfWeek}");
            Console.Write($"\nDate only: {Now.ToShortDateString()}");
            Console.Write($"\nTime only: {Now.ToShortTimeString()}");

            Now = Now.AddYears(4);
            Console.Write($"\n\nFuture date: {Now}");

            DateTime dt = new DateTime(2022, 9, 16, 9, 00, 30);
            Console.Write("\n\nSet date and time: {0:f}", dt);

            Console.Write("\nDay name: {0:dddd}", dt);
            Console.Write("\nLong date: {0:D}", dt);
            Console.Write("\nLong time: {0:T}", dt);

            Console.ReadLine();
        }
    }
}