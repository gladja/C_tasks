// Задана строка, содержащая арифметическое выражение, состоящее из целых
// чисел и знаков операций (бинарных): +, -, *, / (без скобок). Проверить корректность
// выражения (последовательность чисел и знаков операций). В случае корректности вычислить
// значение с учетом приоритетов операций.

using System;
using System.Text;
using System.Collections.Generic;

public class Test
{
    static int SymblPriority(char s)
    {
        switch (s)
        {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            default:
                return 0;
        }
    }

    static double Calculate(double a, double b, char s)
    {
        // double err = 0;
        switch (s)
        {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
            case '/':
                if (b == 0)
                {
                    Console.WriteLine("Error");
                }
                return a / b;
            default:
                return 0;
        }
    }

    static void Result(string data)
    {
        StringBuilder text = new StringBuilder(data);
        Stack<double> listNum = new Stack<double>();
        Stack<char> symbol = new Stack<char>();
        int minus = 0;
        int minus2 = 0;

        if (text[0] == '-')
        {
            minus2 = 1;
            text[0] = '0';
        }

        for (int i = 0; i < text.Length; i++)
        {
            // if (char.IsDigit(text[i]))
            if (text[i] >= '0' && text[i] <= '9')
            {
                double num = 0;
                // while (text[i] >= '0' && text[i] <= '9')
                while (i < text.Length && text[i] >= '0' && text[i] <= '9')
                {
                    num *= 10;
                    num += (text[i] - 48);
                    i++;
                }
                i--;

                if (minus2 == 1 && minus == 0)
                {
                    num *= -1;
                }
                // Console.WriteLine($"{num} ");
                listNum.Push(num);
                minus = 1;
            }
            else if (text[i] == '+' || text[i] == '-' || text[i] == '*' || text[i] == '/')
            {

                while (symbol.Count > 0 && SymblPriority(symbol.Peek()) >= SymblPriority(text[i]))
                {
                    double b = listNum.Pop();
                    double a = listNum.Pop();
                    char s = symbol.Pop();
                    listNum.Push(Calculate(a, b, s));
                }
                symbol.Push(text[i]);
            }
        }

        while (symbol.Count > 0)
        {
            double b = listNum.Pop();
            double a = listNum.Pop();
            char s = symbol.Pop();
            listNum.Push(Calculate(a, b, s));
            // Console.WriteLine($"{a} {b} {s}");
        }

        if (listNum.Count != 1)
        {
            throw new ArgumentException("Invalid expression.");
        }
        Console.WriteLine($"{listNum.Peek()}");
    }


    static void Main(string[] args)

    {
        try
        {
            string example = Console.ReadLine().Trim();
            // .Replace(" ", "");
            Result(example);
        }
        catch
        {
            Console.WriteLine("Not correct example");
        }
    }

}

