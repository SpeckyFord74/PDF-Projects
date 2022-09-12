using System;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int i = 0;

            while(i < nums.Length)
            {
                nums[i] = i;
                Console.Write($"| {nums[i]}");
                i++;
            }
            Console.Write("\n\n");

            do
            {
                i--;
                Console.Write($"|{nums[i]}");
                if (i == 8) { Console.Write("|Skipped"); continue;}
                if (i == 3) { Console.Write("|Done"); break;}
            } while(i > 0);

            Console.ReadKey();
        }
    }
}
