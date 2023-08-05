using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int i = 10;
            a *= 100;

            a *= i;
            a /= 100;
            b *= i;
            // int sum = (a + b) * i;
            Console.WriteLine("{0},{1}", a, b);

        }
    }
}
