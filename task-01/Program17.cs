using System;

namespace task_17
{
    class Program
    {
        static void Main()
        {
            int numOne = Convert.ToInt32(Console.ReadLine());
            int numTwo = Convert.ToInt32(Console.ReadLine());
            double sumOne = numOne * 0.3048;
            double sumTwo = numTwo * 0.0254;
            double sum = sumOne + sumTwo;

            Console.WriteLine("{0}'{1}\" = {2:F2}m.", numOne, numTwo, sum);
        }
    }
}

