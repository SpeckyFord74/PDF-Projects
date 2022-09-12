using System;
using System.Collections.Generic;

namespace Key_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> BookList = 
                new Dictionary<string, string>();
            BookList.Add("Stuart Yarnold", "Arduino");
            BookList.Add("Nick Vandome", "Windows 10");
            BookList.Add("Mike McGrath", "Java");

            Console.WriteLine("Popular Titles...");

            foreach (KeyValuePair<string, string> books in BookList)
            {
                Console.WriteLine($"Key: {books.Key}\tValue: {books.Value} in easy steps");
            }

            Console.ReadKey();
        }
    }
}