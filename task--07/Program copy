using System;

namespace task_10
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            int a = num / 1000;
            int b = (num / 100) % 10;
            int c = (num / 10) % 10;
            int d = num % 10;


            if (b != 0 && a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                // Console.WriteLine("yes1");
            }

            if (b != 0 && b > c)
            {
                b = b + c;
                c = b - c;
                b = b - c;
                // Console.WriteLine("yes2");

            }

            if (b != 0 && a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                // Console.WriteLine("yes3");

            }

            if (c > d)
            {
                c = c + d;
                d = c - d;
                c = c - d;
            }

            if (b > c)
            {
                b = b + c;
                c = b - c;
                b = b - c;
            }

            if (a > d)
            {
                a = a + d;
                d = a - d;
                a = a - d;
            }

            if (b != 0 && a > c)
            {
                a = a + c;
                c = a - c;
                a = a - c;
            }

            Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
        }
    }
}
