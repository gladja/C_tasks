﻿using System;

public class Test
{

    static void Result(string data, int n, int m)
    {

        for (int i = 0; i < data.Length; i++)
        {

            if (i < n - 1 || i > m - 1)
            {
                Console.Write($"{data[i]}");
            }
        }
    }


    static void Main(string[] args)

    {
        string data = Console.ReadLine();

        string[] data2 = Console.ReadLine().Trim().Split();
        int n = int.Parse(data2[0]);
        int m = int.Parse(data2[1]);


        Result(data, n, m);
    }

}
