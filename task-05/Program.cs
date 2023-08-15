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

            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    // Console.WriteLine($"i:{arr[i]} j:{arr[j]}");
                    if (arr[j + 1] < arr[j])
                    {
                        int t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }

                    if (arr[j + 1] > arr[j] && arr[j] > 0)
                    {
                        int t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            return arr;
        }

        static void Created(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        static void Main(string[] args)

        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());

            Created(CountOfDifferent(myArr));
            // CountOfDifferent(myArr);
        }
    }
}

