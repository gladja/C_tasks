﻿using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {

            int num = int.Parse(Console.ReadLine());
            int max = num;
            int min = 0;
            int count = 0;

            while (num != 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }

                if (num >= max)
                {
                    max = num;
                    min = num;
                    count = 0;
                }

                if (count == 0 && num < max)
                {
                    min = num;
                    count++;
                }

                if (count > 0 && num > min)
                {
                    min = num;
                }
            }
            // Console.WriteLine($"count:{count}");
            // Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}



