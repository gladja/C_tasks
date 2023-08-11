﻿using System;

namespace Hello
{
    class Program
    {

        static int[] InitByKeyBoard(int a, int b)
        {
            int[] arr = new int[10];
            arr[0] = a;
            arr[1] = b;
            for (int i = 2; i < 10; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr;
        }

        static void Revers(int[] arr)
        {
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        static void Main(string[] args)

        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);

            Revers(InitByKeyBoard(a, b));

        }
    }
}

