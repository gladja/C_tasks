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
        int[] arrSum = new int[m];
        for (int i = 0; i < m; i++)
        {
            int res = 0;
            for (int j = 0; j < n; j++)
            {
                string text = Math.Abs(arr[j, i]).ToString();
                for (int k = 0; k < text.Length; k++)
                {
                    int b = int.Parse($"{text[k]}");
                    res += b;
                }
            }
            arrSum[i] = res;
        }


        for (int i = 0; i < arrSum.Length - 1; i++)
        {
            for (int j = 0; j < arrSum.Length - i - 1; j++)
            {
                if (arrSum[j + 1] < arrSum[j])
                {
                    int temp = arrSum[j + 1];
                    arrSum[j + 1] = arrSum[j];
                    arrSum[j] = temp;

                    for (int k = 0; k < n; k++)
                    {
                        int temp2 = arr[k, j + 1];
                        arr[k, j + 1] = arr[k, j];
                        arr[k, j] = temp2;
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