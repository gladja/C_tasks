﻿using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (num > 0)
            {
                int rez = num % 2;
                num /= 2;
                if (rez > 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);


        }
    }
}




