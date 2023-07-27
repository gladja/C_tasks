using System;

namespace task_15
{
    class Program
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());


            if ((a % 2 == 0) && a > 0)
            {
                Console.WriteLine("YES");
                Console.WriteLine(a + 2);
            }
            else
            {
                Console.WriteLine("NO");
                if (a < 0)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(a + 1);
                }
            }
        }
    }
}
