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
            int max = arr[0];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    count++;
                }
                max = arr[i];

            }

            Console.WriteLine(count);
        }

        static void Main(string[] args)

        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());

            CountOfDifferent(myArr);
        }
    }
}

