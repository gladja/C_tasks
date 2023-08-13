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

        static void CreatedArr(int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > 0 && arr[i] > 0 || arr[i - 1] < 0 && arr[i] < 0)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }





        static void Main(string[] args)

        {
            int k = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                int n = Convert.ToInt16(Console.ReadLine());
                int[] myArr = InitByKeyBoard(Console.ReadLine());
                CreatedArr(myArr);
            }



        }
    }
}

