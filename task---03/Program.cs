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

            int n = int.Parse(Console.ReadLine());
            int count = 1;

            int countH = 0;
            Console.WriteLine($" {a.ToString("00")}:{b.ToString("00")}");
            while (n > count)
            {
                count++;
                for (int i = 1; i <= 5; i++)
                {
                    if (b % 59 == 0 && b != 0)
                    {
                        b = 0;
                        countH++;
                        // Console.WriteLine(b);
                    }
                    else
                    {
                        b += 1;
                        // Console.WriteLine(b);
                    }
                }

                if (countH > 0)
                {
                    if (a % 23 == 0 && a != 0)
                    {
                        a = 0;
                    }
                    else
                    {
                        a++;
                    }
                }
                countH = 0;
                // Console.WriteLine();
                Console.WriteLine($" {a.ToString("00")}:{b.ToString("00")}");
            }
        }
    }
}

