﻿using System;

public class Test
{

    static int[,] InitByKeyBoardLine(int n)
    {
        int[,] arr = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - (i + 1); j++)
            {
                arr[i, j] = 2;
            }
        }

        int k = 1;
        for (int i = n - 1; i > 0; i--)
        {
            for (int j = k; j < n; j++)
            {
                arr[i, j] = 1;
            }
            k++;
        }


        return arr;
    }

    static void NewArr(int[,] arr)
    {

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
        int n = Convert.ToInt16(Console.ReadLine());
        NewArr(InitByKeyBoardLine(n));
    }
}

