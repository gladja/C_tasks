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

            if (a != 0 && b != 0 && c != 0 && d != 0)
            {
                if (a > b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }

                if (b > c)
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;

                }

                if (a > b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
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

                if (a > b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }

                Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
            }
            //d==0
            if (a != 0 && b != 0 && c != 0 && d == 0)
            {
                if (a > b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
                if (b > c)
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;
                }
                if (a > b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
                Console.WriteLine("{0}{1}{2}{3}", a, d, b, c);
            }
            //c==0
            if (a != 0 && b != 0 && c == 0 && d != 0)
            {
                if (a > b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
                if (b > d)
                {
                    b = b + d;
                    d = b - d;
                    b = b - d;
                }
                if (a > b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
                Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
            }
            //b==0
            if (a != 0 && b == 0 && c != 0 && d != 0)
            {
                if (a > c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;
                }
                if (c > d)
                {
                    c = c + d;
                    d = c - d;
                    c = c - d;
                }
                if (a > c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;
                }
                Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
            }
            //c==0 d==0
            if (a != 0 && b != 0 && c == 0 && d == 0)
            {
                if (a > b)
                {
                    Console.WriteLine("{0}{1}{2}{3}", b, c, d, a);
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}", a, c, d, b);
                }
            }
            //b==0 d==0
            if (a != 0 && b == 0 && c != 0 && d == 0)
            {
                if (a > c)
                {
                    Console.WriteLine("{0}{1}{2}{3}", c, b, d, a);
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}", a, b, d, c);
                }
            }
            //b==0 c==0
            if (a != 0 && b == 0 && c == 0 && d != 0)
            {
                if (a > d)
                {
                    Console.WriteLine("{0}{1}{2}{3}", d, b, c, a);
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
                }
            }
            //b==0 c==0 d==0
            if (b == 0 && c == 0 && d == 0)
            {
                Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
            }
        }
    }
}
