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

    static void NewArr(int[,] arr, int n, int m)
    {
        int min = arr[0, 0];
        int max = arr[0, 0];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (min > arr[i, j])
                {
                    min = arr[i, j];
                }
                if (max < arr[i, j])
                {
                    max = arr[i, j];
                }
                sum += arr[i, j];

            }
        }
        Console.Write($"{sum} {min} {max}");
    }

    static void Main(string[] args)

    {
        string[] data = Console.ReadLine().Trim().Split();
        int n = int.Parse(data[0]);
        int m = int.Parse(data[1]);

        NewArr(InitByKeyBoardLine(n, m), n, m);
    }

}