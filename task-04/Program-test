using System;

namespace task_01
{
    class Program
    {
        static void PrintAllFracs(int num)
        {
            double sum = 0;
            int count = 0;

            for (double i = 1; i <= num; i++)
            {
                count++;
                for (double j = 0; j <= num; j++)
                {
                    sum = i / j;
                    if (sum > 0 && sum < 1)
                    {
                        if (j == count)
                        {

                        }
                        Console.WriteLine($"{i}/{j}");
                    }
                }
            }
        }
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            PrintAllFracs(num);
        }
    }
}



