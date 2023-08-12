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
            int max = 0;
            int firstMax = 0;
            int value = 0;


            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                string res = arr[i].ToString();
                for (int j = 0; j < res.Length; j++)
                {
                    int b = int.Parse($"{res[j]}");
                    value += b;
                }
                if (value >= max)
                {
                    max = value;
                    firstMax = arr[i];
                    if (firstMax < arr[i])
                    {
                        count = i;
                    }
                }

                value = 0;
            }
            Console.WriteLine(arr[count]);
            // Console.WriteLine(min);
            // Console.WriteLine(max);
            // return max;
        }


        static void Main(string[] args)

        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());

            CountOfDifferent(myArr);
        }
    }
}

