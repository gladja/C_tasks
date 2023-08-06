using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Trim().Split();
            double n = double.Parse(data[0]);
            double x = double.Parse(data[1]);
            double sum = n;
            int count = 1;

            for (int i = 0; sum < x; i++)
            {
                sum += sum * 0.1;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}