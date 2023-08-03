using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            int sum = 2;

            while (num > sum)
            {
                count += 1;
                sum *= 2;
                // sum *= count;
            }
            Console.WriteLine(count);

            // for (int i = 1; sum < num; i++)
            // {
            //     sum *= 2;
            //     count += 1;
            // }
            // Console.WriteLine(count);

            // do
            // {
            //     count += 1;
            //     sum *= count;
            // }
        }
    }
}




