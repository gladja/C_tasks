﻿using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double sum = 1.1;
            double x = 1.1;

            for (int i = 2; i <= n; i++)
            {
                x += 0.1;
                sum *= x;
                // Console.WriteLine(x);
            }
            Console.WriteLine($"{sum:F6}");
        }
    }
}

