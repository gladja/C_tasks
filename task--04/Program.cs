using System;

namespace task_04
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

            if ((a >= 1000) && (a <= 9999) && (a > 0) && (a % 2 != 0) && (a % 3 != 0) && (a % 5 != 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

            if ((b >= 1000) && (b <= 9999) && (b > 0) && (b % 2 != 0) && (b % 3 != 0) && (b % 5 != 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

            if ((c >= 1000) && (c <= 9999) && (c > 0) && (c % 2 != 0) && (c % 3 != 0) && (c % 5 != 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

            if ((d >= 1000) && (d <= 9999) && (d > 0) && (d % 2 != 0) && (d % 3 != 0) && (d % 5 != 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

            if ((e >= 1000) && (e <= 9999) && (e > 0) && (e % 2 != 0) && (e % 3 != 0) && (e % 5 != 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
