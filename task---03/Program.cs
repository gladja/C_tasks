﻿using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int sum = 0;


            for (int i = a; i <= b; i++)
            {
                sum += i * i;
            }
            Console.WriteLine(sum);
        }
    }
}

