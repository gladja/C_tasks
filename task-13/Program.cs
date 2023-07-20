using System;

namespace task_13
{
    class Program
    {
        static void Main()
        {
            double sumOne = (7 - 6.35) / 6.5 + 9.9;
            double sumTwo = (1.2 / 36 + 1.2 / 0.25 - (21.0 / 16)) / (169.0 / 24);
            double sum = sumOne / sumTwo;
            Console.WriteLine(sum);
        }
    }
}