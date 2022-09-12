using System;

namespace Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            double Weight;
            string Num;

            Num = getWeight(out Weight);
            Console.WriteLine(Num + "lb = " + lbToKg(Weight) + "kg");
            kgToLb(ref Weight);
            Console.WriteLine(Num + "kg = " + Weight + "lb");

            Console.ReadKey();
        }

        static string getWeight(out double Weight)
        {
            Weight = 10;
            return "Ten";
        }

        static double lbToKg(double Pounds = 5)
        {
            return (Pounds * 0.45359237);
        }

        static void kgToLb(ref double Weight)
        {
            Weight = (Weight / 0.45359237);
        }
    }
}