using System;

namespace task_10
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            if (num > 99 && num < 1000)
            {
                int a = num / 100;
                int b = (num / 10) % 10;
                int c = num % 10;


                if (a == 0 || b == 0 || c == 0)
                {
                    sum += 1;

                    if ((c == 3 || c == 6 || c == 9))
                    {
                        Console.WriteLine("NO");
                    }
                    else
                    {
                        Console.WriteLine("YES");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                int a = num / 1000;
                // Console.WriteLine(a);
                int b = (num / 100) % 10;
                // Console.WriteLine(b);
                int c = (num / 10) % 10;
                // Console.WriteLine(c);
                int d = num % 10;
                // Console.WriteLine(d);

                if (a != b && a != b && a != d && b != c && b != d && c != d)
                {
                    if ((d == 3 || d == 6 || d == 9))
                    {
                        Console.WriteLine("NO1");
                    }
                    else
                    {
                        Console.WriteLine("YES");
                    }
                }
                else
                {
                    Console.WriteLine("NO2");
                }
            }
        }
    }
}
