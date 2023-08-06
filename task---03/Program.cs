using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int max = num;
            int max2 = num;


            while (num != 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                // else
                // {
                if (num > max)
                {
                    max = num;
                }
                // }
            }
            Console.WriteLine(max);

        }
    }
}










