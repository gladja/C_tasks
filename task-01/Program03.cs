using System;

namespace task_03
{
    class Program
    {
        static void Main()
        {
            // double number = 12.34234234;
            // string? number = Console.ReadLine();
            // string str = Console.ReadLine();
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("{0:F}", num);
            // Console.WriteLine(Math.IEEERemainder(number));
        }
    }
}
