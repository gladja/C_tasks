﻿using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (num > 0 || num < 0)
            {
                if (num % 2 != 0)
                {
                    count += 1;
                }
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(count);
        }
    }
}




