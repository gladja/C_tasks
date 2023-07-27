using System;

namespace task_11
{
    class Program
    {
        static void Main()
        {
            double sumOne = ((4.625 - (13.0 / 18) * (9.0 / 26)) / (9.0 / 4) + 2.5 / 1.25 / 6.75) / (121.0 / 68);
            double sumTwo = (0.5 - 0.375) / 0.125 + ((5.0 / 6) - (7.0 / 12)) / (0.358 - 1.4796 / 13.7);
            double sum = sumOne / sumTwo;
            Console.WriteLine(sum);
        }
    }
}


