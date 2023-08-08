using System;

namespace task_10
{
    class Program
    {
        static void Main()
        {
            // string[] data = Console.ReadLine().Trim().Split();
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int max;
            int min;

            // 3 4 5 
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            if (max < c)
            {
                max = c;
            }

            if (a < b)
            {
                min = a;
            }
            else
            {
                min = b;
            }

            if (min > c)
            {
                min = c;
            }

            // Console.WriteLine(max);
            // Console.WriteLine(min);
            // max = max * max;
            // min = min * min;

            if (max > min)
            {
                max = max * max;
                min = min * min;
                Console.WriteLine("{0}\n{1}", max, min);
            }
            else
            {
                max = max * max;
                min = min * min;
                Console.WriteLine("{0}\n{1}", min, max);
            }
        }
    }
}
