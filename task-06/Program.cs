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
        int[] arrSum = new int[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                arrSum[i] += arr[i, j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(arrSum[i]) < Math.Abs(arrSum[j]))
                {
                    int temp = arrSum[i];
                    arrSum[i] = arrSum[j];
                    arrSum[j] = temp;

                    for (int k = 0; k < m; k++)
                    {
                        int temp2 = arr[i, k];
                        arr[i, k] = arr[j, k];
                        arr[j, k] = temp2;
                    }
                }
            }
        }

        // for (int i = 0; i < arrSum.Length; i++)
        // {
        //     Console.WriteLine(arrSum[i]);
        // }

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
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