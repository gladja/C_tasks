using System;

namespace task_07
{
    class Program
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int sum = a + b;

            Console.WriteLine($"{a}+{b}={sum}");
        }
    }
}
