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

    static void SumArrRow(int[,] arr, int n, int m)
    {
        int[] arrSum = new int[0];
        int k = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                {
                    Array.Resize(ref arrSum, arrSum.Length + 1);
                    arrSum[k] = arr[i, j];
                    k++;
                }
            }
        }

        for (int i = 0; i < arrSum.Length - 1; i++)
        {
            for (int j = 0; j < arrSum.Length - i - 1; j++)
            {
                if (Math.Abs(arrSum[j + 1]) >= Math.Abs(arrSum[j]))
                {
                    int t = arrSum[j + 1];
                    arrSum[j + 1] = arrSum[j];
                    arrSum[j] = t;
                }
            }
        }

        for (int i = 0; i < arrSum.Length; i++)
        {
            Console.WriteLine(arrSum[i]);
        }

    }

    static void Main(string[] args)

    {
        string[] data = Console.ReadLine().Trim().Split();
        int n = int.Parse(data[0]);
        int m = int.Parse(data[1]);

        SumArrRow(InitByKeyBoardLine(n, m), n, m);
    }

}