using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            bodyTempC();
            Console.WriteLine($"Farenheit:\t{bodyTempF()}ºF");
            Console.WriteLine($"Kelvin:\t{bodyTempK()}K");

            Console.ReadKey();
        }

        static void bodyTempC()
        {
            Console.WriteLine("Body Temperature...");
            Console.WriteLine("Centigrade:\t37ºC");
        }

        static double bodyTempF()
        {
            double temperature = 98.6;
            return temperature;
        }

        static int bodyTempK()
        {
            int temperature = 310;
            return temperature;
        }
    }
}