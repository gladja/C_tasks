﻿using System;

namespace Hello
{
    class Program
    {

        static int[] InitByKeyBoard(string str)
        {
            string[] date = str.Trim().Split();
            int[] arr = new int[date.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(date[i]);
            }
            return arr;
        }

        static void CountOfDifferent(int[] arr, int f, int k)
        {
            int count = 0;
            if (f > k)
            {
                Console.WriteLine("Error");
                return;
            }

            for (int i = f; i < k; i++)
            {
                count++;
            }
            if (count < 10)
            {
                Console.WriteLine(arr[count]);
            }
            else
            {
                Console.WriteLine("Error");
            }

            // if (f >= 0 && f < arr.Length && k >= 0 && k < arr.Length)
            // {
            //     for (int i = f; i <= k; i++)
            //     {
            //         Console.WriteLine($"{arr[i]}");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Error");
            // }
        }

        static void Main(string[] args)

        {
            int[] myArr = InitByKeyBoard(Console.ReadLine());
            string[] data = Console.ReadLine().Trim().Split();
            int f = int.Parse(data[0]);
            int k = int.Parse(data[1]);

            CountOfDifferent(myArr, f, k);
        }
    }
}

