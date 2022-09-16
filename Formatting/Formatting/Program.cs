using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Formatting";

            int Sum = 2500;
            Console.WriteLine($"Currency string: {Sum.ToString("C")}");

            Console.Write(String.Format("\nGeneral:\t{0:G}", Sum));
            Console.Write(String.Format("\nFixed point:\t{0:F}", Sum));
            Console.Write(String.Format("\nNumber:\t{0:N}", Sum));
            Console.Write(String.Format("\nCurrency:\t{0:C}", Sum));

            Sum /= 1000;
            Console.Write(String.Format("\nPercentage:\t{0:P}", Sum));
            Console.Write(String.Format("\nZero padded:\t{0:00.0000}\n", Sum));

            string Data = "Mike,McGrath,Author";
            string[] Items = Data.Split(',');
            foreach(string Item in Items)
            {
                Console.Write(String.Format("\n*{0}", Item));
            }

            Console.ReadLine();
        }
    }
}