﻿using System;

public class Test
{

    static void Result(string data, int n)
    {
        int res = 0;
        int max = 0;
        for (int i = 0; i < data.Length - 1; i++)
        {
            // count = data.IndexOf(data[i]);
            int count = 0;

            if (data[i] == data[i + 1])
            {
                count++;
            }
            Console.Write($"{count} ");
        }
    }


    static void Main(string[] args)

    {
        int n = Convert.ToInt16(Console.ReadLine());
        string data = Console.ReadLine();

        Result(data, n);
    }

}
