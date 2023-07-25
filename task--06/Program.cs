using System;

namespace task_06
{
    class Program
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int c = int.Parse(data[2]);
            int d = int.Parse(data[3]);
            int e = int.Parse(data[4]);

            if (a % 2 != 0)
            {
                Console.WriteLine("YES");
            }
            else if (a > 0)
            {
                Console.WriteLine("YES");
            }
            else if ((a > 99) && (a < 1000))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            if (b % 2 != 0)
            {
                Console.WriteLine("YES");
            }
            else if (b > 0)
            {
                Console.WriteLine("YES");
            }
            else if ((b > 99) && (a < 1000))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            if (c % 2 != 0)
            {
                Console.WriteLine("YES");
            }
            else if (c > 0)
            {
                Console.WriteLine("YES");
            }
            else if ((c > 99) && (a < 1000))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            if (d % 2 != 0)
            {
                Console.WriteLine("YES");
            }
            else if (d > 0)
            {
                Console.WriteLine("YES");
            }
            else if ((d > 99) && (a < 1000))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            if (e % 2 != 0)
            {
                Console.WriteLine("YES");
            }
            else if (e > 0)
            {
                Console.WriteLine("YES");
            }
            else if ((e > 99) && (a < 1000))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
