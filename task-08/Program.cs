﻿// Задана строка, содержащая арифметическое выражение, состоящее из целых
// чисел и знаков операций (бинарных): +, -, *, / (без скобок). Проверить корректность
// выражения (последовательность чисел и знаков операций). В случае корректности вычислить
// значение с учетом приоритетов операций.

using System;
using System.Text;
using System.Collections.Generic;

public class Test
{

    static void Result(string data)
    {
        StringBuilder text = new StringBuilder(data);
        List<double> list = new List<double>();
        Stack<double> val = new Stack<double>();


        for (int i = 0; i < text.Length; i++)
        {
            // char ch = text[i];
            if (char.IsDigit(text[i]))
            {
                double num = 0;
                // while (text[i] >= '0' && text[i] <= '9')
                while (i < text.Length && char.IsDigit(text[i]))
                {
                    num *= 10;
                    num += (text[i] - 48);
                    i++;
                }
                i--;
                Console.WriteLine($"{num} ");
                list.Add(num);
            }
            else
            {
                if (text[i] == '-' || text[i] == '+' || text[i] == '*' || text[i] == '/')
                {
                    // Console.Write($"{i}");
                }
                else
                {
                    Console.WriteLine("error");

                }
            }

        }
    }


    static void Main(string[] args)

    {
        // string example = Console.ReadLine().Trim().Replace(" ", "");
        string example = Console.ReadLine().Trim().Replace(" ", "");
        // string example = "33+2";

        Result(example);
    }

}

