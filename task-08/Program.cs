﻿// Задана строка, содержащая арифметическое выражение, состоящее из целых
// чисел и знаков операций (бинарных): +, -, *, / (без скобок). Проверить корректность
// выражения (последовательность чисел и знаков операций). В случае корректности вычислить
// значение с учетом приоритетов операций.

using System;
using System.Text;

public class Test
{

    static void Result(string data)
    {
        StringBuilder text = new StringBuilder(data);

        // int a = 0;
        // int b = 0;
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            // Console.Write($"{data[i]} ");
            if (text[i] == '*')
            {
                int a = text[i - 1] - 48;
                int b = text[i + 1] - 48;
                int res = a * b;
                // char text = (char)res;
                // data.Remove(a, 2);

                Console.WriteLine(i);
                text.Remove(i - 1, 3).Insert(i - 1, $"{res}");
                // result = data.Insert(a, "4");
                i = 0;
                // break;
            }
        }
        // Console.WriteLine((char)a);
        // Console.WriteLine((char)a);
        Console.WriteLine(text);

        // for (int i = 0; i < text.Length; i++)
        // {
        //     Console.Write($"{text[i]}");
        // }

    }


    static void Main(string[] args)

    {
        // string example = Console.ReadLine().Trim().Replace(" ", "");
        string example = Console.ReadLine().Trim().Replace(" ", "");

        Result(example);
    }

}


