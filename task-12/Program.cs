using System;

namespace task_12
{
    class Program
    {
        static void Main()
        {
            double sumOne = (((11.0 / 4) / 1.1 + (10.0 / 3)) / (2.5 - 0.4 * (10.0 / 3))) / (5.0 / 7);
            double sumTwo = (((13.0 / 6) + 4.5) * 0.375) / (2.75 - (3.0 / 2));
            double sum = sumOne - sumTwo;
            Console.WriteLine(sum);
        }
    }
}