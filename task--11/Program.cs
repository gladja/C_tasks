using System;

namespace task_11
{
    class Program
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);

            int max;
            int min;

            // 3 4  
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }


            if (a < b)
            {
                min = a;
            }
            else
            {
                min = b;
            }


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
