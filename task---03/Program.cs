﻿using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = num;
            int count = 1;

            while (num != 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (sum <= num)
                {
                    count += 1;
                }
                else
                {
                    break;
                }
                sum = num;
            }
            Console.WriteLine(count);

        }
    }
}










