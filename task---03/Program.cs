using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine()) / 10;
            double y = x;
            double a = Math.Floor(x);

            Console.WriteLine(x);
            Console.WriteLine(a);
            Console.WriteLine(x - a);

            for (int i = 1; i <= 15; i++)
            {
                x *= i;

                if (i < 10)
                {
                    if (x - a < 0.1)
                    {
                        Console.WriteLine($" {i * 100} grams: {x.ToString("0.00").Replace(".0", " UAH ")} kop");

                    }
                    else
                    {
                        Console.WriteLine($" {i * 100} grams: {x.ToString("0.00").Replace(".", " UAH ")} kop");
                    }
                }
                else
                {
                    if (x - a < 0.1)
                    {
                        Console.WriteLine($"{i * 100} grams: {x.ToString("0.00").Replace(".0", " UAH ")} kop");
                    }
                    else
                    {
                        Console.WriteLine($"{i * 100} grams: {x.ToString("0.00").Replace(".", " UAH ")} kop");
                    }
                }

                x = y;
            }
        }
    }
}

// https://learn.microsoft.com/ru-ru/dotnet/standard/base-types/custom-numeric-format-strings#the-0-custom-specifier
// Console.WriteLine(x.ToString("0.00").Replace(".", ","));
// Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.00}", x));
// Console.WriteLine(String.Format("{0:00000}", x));

// x = x.Substring(0, 2);
// Console.WriteLine($"{x:F2}");
// string str = project.Variables["number"].Value.Replace(".", ",").Trim().Substring(0, 5)

// string str = string.Empty + x;
// str = str.Replace(".", ",");
// string form = str.PadRight(0, "0");

// Console.WriteLine($"{x:F2}");
// Console.WriteLine($"{str}");
// Console.WriteLine($"{str}");

// b.PadLeft(2, 0);
// int sum = (a + b) * i;
// if (b < 10)
// {
//     Console.WriteLine($"{i} kg: {a},0{b} UAH");
// }
// else
// {
//     Console.WriteLine($"{i} kg: {a},{b} UAH");
// }
// Console.WriteLine($"{i} kg: {a},{b} UAH");
