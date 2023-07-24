using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine('0');
            }
            else if (num > 0)
            {
                num = num * num;
                Console.WriteLine(num);
            }
            else
            {
                num *= -1;
                Console.WriteLine(num);
            }
        }
    }
}
