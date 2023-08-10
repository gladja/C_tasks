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

        static void CountOfDifferent(int[] arr)
        {
            double max = 0;
            double count = 0;
            double value = 0;

            for (int i = 1; i < arr.Length; i += 2)
            {

                if (arr[i] % 2 != 0)
                {
                    value += arr[i];
                    count++;
                    max = value / count;
                }

            }
            if (max == 0)
            {
                Console.WriteLine(max);
            }
            else
            {
                Console.WriteLine("{0:F4}", max);
            }
        }

        static void Main(string[] args)

        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());

            CountOfDifferent(myArr);
        }
    }
}

