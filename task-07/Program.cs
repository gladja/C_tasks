﻿using System;

public class Test
{

    static void Result(string data)
    {
        int num = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == ' ')
            {
                num++;
            }
        }
        Console.WriteLine($"{num}");
    }

    static void Main(string[] args)

    {
        string data = Console.ReadLine();

        Result(data);
    }
}
