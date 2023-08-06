using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int sum = k;
            int sum2 = k;

            while (sum % k == 0 && sum < 10000)
            {

                sum += k;
                if (sum < 10000 && sum > 999)
                {
                    sum2 += sum;
                    Console.WriteLine(sum);
                }
                // Console.WriteLine(sum);
            }
            Console.WriteLine(sum2);
        }
    }
}