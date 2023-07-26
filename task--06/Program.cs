using System;

namespace task_06
{
    class Program
    {
        static void Main()
        {
            // string[] data = Console.ReadLine().Trim().Split();
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());

            if ((a % 2 != 0) || (a > 0 && (a > 99 && a < 1000)))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            if ((b % 2 != 0) || (b > 0 && (b > 99 && b < 1000)))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            if ((c % 2 != 0) || (c > 0 && (c > 99 && c < 1000)))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            if ((d % 2 != 0) || (d > 0 && (d > 99 && d < 1000)))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            if ((e % 2 != 0) || (e > 0 && (e > 99 && e < 1000)))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
