using System;

namespace task_05
{
    class Program
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);

            int s = a * b;
            int p = 2 * (a + b);
            Console.WriteLine("The perimeter of the rectangle with sides {0} and {1} is {2}.", a, b, p);
            Console.WriteLine("The area of the rectangle with sides {0} and {1} is {2}.", a, b, s);
        }
    }
}
