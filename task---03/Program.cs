﻿using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            double num = Convert.ToDouble(Console.ReadLine());
            int count = 1;
            int count2 = 0;
            double sum = 1;
            double sum2 = 1;


            for (int i = 2; sum <= num; i++)
            {
                sum += 1.0 / i;
                double a = 1.0 / i;
                count++;
                // Console.WriteLine(i);
                // Console.WriteLine(a);
                // Console.WriteLine(sum);
            }

            for (int i = 2; sum2 < num; i++)
            {
                sum2 += 1.0 / i;
                count2++;
                // Console.WriteLine(i);
                // Console.WriteLine(sum2);
            }

            Console.WriteLine($"{count2} {count}");
        }
    }
}




