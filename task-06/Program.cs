﻿using System;

public class Test
{

    static int[][] InitByKeyBoardLine(int n, int m)
    {
        int[][] arr = new int[n][];
        string[] str_arr;
        for (int i = 0; i < n; i++)
        {
            arr[i] = new int[m];
            str_arr = (Console.ReadLine()).Split(' ');
            for (int j = 0; j < m; j++)
            {
                arr[i][j] = Convert.ToInt32(str_arr[j]);
            }
        }
        return arr;
    }

    static void NewArr(int[][] arr, int n, int m)
    {
        // int count = 0;
        for (int i = 0; i < n; i++)
        {
            int min = arr[i][0];
            for (int j = 0; j < m - 1; j++)
            {
                if (min > arr[i][j + 1])
                {
                    min = arr[i][j + 1];
                }
            }
            Console.Write($"{min} ");
        }
    }

    static void Main(string[] args)

    {
        string[] data = Console.ReadLine().Trim().Split();
        int n = int.Parse(data[0]);
        int m = int.Parse(data[1]);

        NewArr(InitByKeyBoardLine(n, m), n, m);
    }

}