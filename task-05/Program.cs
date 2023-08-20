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

        static int[] CountOfDifferent(int[] arr)
        {
            int[] idx = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                idx[i] = i + 1;
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    // Console.WriteLine($"i:{arr[i]} j:{arr[j]}");
                    if (arr[j + 1] > arr[j])
                    {
                        int t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;

                        int w = idx[j + 1];
                        idx[j + 1] = idx[j];
                        idx[j] = w;

                    }
                }
            }
            for (int i = 0; i < idx.Length; i++)
            {
                Console.Write($"{idx[i]} ");
            }
            return arr;
        }



        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());
            // int[] arrCopy = new int[myArr.Length];
            // Array.Copy(myArr, arrCopy, myArr.Length);

            CountOfDifferent(myArr);
            // CreatedTwo(arrCopy);
        }
    }
}