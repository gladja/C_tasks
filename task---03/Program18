using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int count = 0;
            int count2 = 0;
            int a2 = a;
            int b2 = b;

            if (a < b)
            {
                while (a <= b)
                {
                    a++;
                    count++;
                }
                Console.WriteLine($"{count} very important numbers:");
                Console.WriteLine(a2);

                while (a2 < b2)
                {
                    a2++;
                    Console.WriteLine(a2);
                }

            }
            else
            {

                while (a >= b)
                {
                    a--;
                    count++;
                }
                Console.WriteLine($"{count} very important numbers:");
                Console.WriteLine(a2);

                while (a2 > b2)
                {
                    a2--;
                    Console.WriteLine(a2);
                }

            }

        }
    }
}