// Задана строка, содержащая арифметическое выражение, состоящее из целых
// чисел и знаков операций (бинарных): +, -, *, / (без скобок). Проверить корректность
// выражения (последовательность чисел и знаков операций). В случае корректности вычислить
// значение с учетом приоритетов операций.

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

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
            case '#':
                return -1;
            default:
                return 0;
        }
    }

    static void Result(string data)
    {
        StringBuilder text = new StringBuilder(data);
        List<double> listNum = new List<double>();
        List<double> listSym = new List<double>();
        // Stack<double> listSym = new Stack<double>();


        for (int i = 0; i < text.Length; i++)
        {
            // char ch = text[i];
            listSym.Add('#');
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
                listNum.Add(num);
            }
            else
            {
                if (text[i] == '+' || text[i] == '-')
                {
                    // listSym.Add(ch);
                    if (SymblPriority((char)listSym.Last()) >= SymblPriority(text[i]))
                    {

                        Console.WriteLine("yes");
                    }
                    // int sum = SymblPriority((listSym.Last()));
                    Console.WriteLine((char)listSym.Last());
                }
                else if (text[i] == '*' || text[i] == '/')
                {

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

