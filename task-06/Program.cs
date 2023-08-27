﻿using System;

public class Test
{

    static int[,] InitByKeyBoardLine(int n, int m)
    {
        int[,] arr = new int[n, m];
        string[] str_arr;
        for (int i = 0; i < n; i++)
        {
            str_arr = (Console.ReadLine()).Split(' ');
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = Convert.ToInt32(str_arr[j]);
            }
        }
        return arr;
    }

    static void Result(int[,] arr, int n, int m)
    {
        int maximum = int.MaxValue;
        int minimum = int.MinValue;
        int max = 0;
        int min = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[j, i] < maximum)
                {
                    maximum = arr[j, i];
                    min = i;
                }

                if (arr[j, i] >= minimum)
                {
                    minimum = arr[j, i];
                    max = i;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            int temp = arr[i, max];
            arr[i, max] = arr[i, min];
            arr[i, min] = temp;
        }

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
        // Console.WriteLine($"{count}");

    }
    static void Main(string[] args)

    {
        string[] data = Console.ReadLine().Trim().Split();
        int n = int.Parse(data[0]);
        int m = int.Parse(data[1]);

        Result(InitByKeyBoardLine(n, m), n, m);
    }

}