﻿using System;

namespace Hello
{
    class Program
    {

        static long[] InitByKeyBoard(string str)
        {
            string[] date = str.Trim().Split();
            long[] arr = new long[date.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(date[i]);
            }
            return arr;
        }

        static long[] CountOfDifferent(long[] arr)
        {
            int n = arr.Length;
            long temp, smallest;
            long first = (int)arr[0];
            long idx = 0;
            int count = 0;

            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;

                for (int k = 0; k < n; k++)
                {
                    if (arr[k] == first && idx != k)
                    {
                        count++;
                        idx = k;
                    }
                }
            }
            Console.WriteLine($"{count}");
            return arr;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            long[] myArr = InitByKeyBoard(Console.ReadLine());

            CountOfDifferent(myArr);
        }
    }
}

