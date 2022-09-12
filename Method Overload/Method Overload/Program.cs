using System;

namespace Method_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Method Overload";

            double Num;
            double Area;

            Console.Write("Please enter dimension in feet: ");
            Num = Convert.ToDouble(Console.ReadLine());

            Area = computeArea(Num);
            Console.WriteLine($"\nCircle:\t\tArea = {Area} sq.ft.");

            Area = computeArea(Num, Num, 'T');
            Console.WriteLine($"Triangle:\tArea = {Area} sq.ft.");

            Console.ReadLine();
        }

        static double computeArea(double Width)
        {
            double Radius = Width * 2;
            return ((Radius * Radius) * 3.141593);
        }

        static double computeArea(double Width, double Height)
        {
            return (Width * Height);
        }

        static double computeArea(double Width, double Height, char letter)
        {
            return ((Width / 2) * Height);
        }
    }
}