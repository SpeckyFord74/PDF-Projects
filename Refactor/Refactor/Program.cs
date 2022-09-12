using System;

namespace Refactor
{
    class System
    {
        static void Main(string[] args)
        {
            computeFactorials(1, 8);
            Console.ReadLine();
        }

        static int Factorial(int Num)
        {
            int Result;
            if(Num == 1)
            {
                Result = 1;
            }
            else
            {
                Result = (Factorial(Num - 1) * Num);
            }
            return Result;
        }

        static void computeFactorials(int Number, int Max)
        {
            while(Number <= Max)
            {
                Console.Write($"Factorial of {Number}:");
                Console.WriteLine(Factorial(Number));
                Number++;
            }
        }
    }
}