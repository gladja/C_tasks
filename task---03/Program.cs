using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            double num = Convert.ToDouble(Console.ReadLine());
            int count = 1;
            int count2 = 0;
            double sum = 1;

            // while (sum < num)
            // {
            //     sum += 1.0 / (count + 1);
            //     count++;
            //     Console.WriteLine(sum);

            // }


            for (int i = 2; sum > num; i++)
            {
                sum += 1.0 / i;
                count++;
                // Console.WriteLine(i);
                Console.WriteLine(sum);
            }
            Console.WriteLine(count);

            // for (int i = 2; sum < num; i++)
            // {
            //     sum += 1.0 / i;
            //     count++;
            //     // Console.WriteLine(i);
            //     Console.WriteLine(sum);
            // }
            // Console.WriteLine(count2);
        }
    }
}




