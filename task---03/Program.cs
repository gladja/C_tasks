﻿using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {

            int num = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            int a = 0;
            int count = 0;

            for (int i = 0, j = 0; i < num || num < j; i++, j--)
            {
                n = num % 10;
                num /= 10;
                // Console.WriteLine(n);
                if (n % 2 != 0)
                {
                    count++;
                }
            }
            // Console.WriteLine(num);
            if (num % 2 != 0)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}








//for (int i = 2; i <= num; i++)
// {
//     if (num % i == 0)
//     {
//         Console.WriteLine(i);
//         break;
//     }
// }


