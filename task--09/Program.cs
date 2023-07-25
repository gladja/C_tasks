using System;

namespace task_09
{
    class Program
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int c = int.Parse(data[2]);

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

            Console.WriteLine("{0} {1} {2}", a, b, c);

        }
    }
}
