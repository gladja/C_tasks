using System;

namespace task_02
{
    class Program
    {
        static void Main()
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);



            string[] dataTwo = Console.ReadLine().Trim().Split();
            int c = int.Parse(dataTwo[0]);
            int d = int.Parse(dataTwo[1]);


            if ((a + b) % 2 == 0)
            {
                Console.Write();
            }

            // int num = Convert.ToInt32(Console.ReadLine());

            // if (num == 0)
            // {
            //     Console.WriteLine('0');
            // }
            // else if (num > 0)
            // {
            //     num = num * num;
            //     Console.WriteLine(num);
            // }
            // else
            // {
            //     num *= -1;
            //     Console.WriteLine(num);
            // }
        }
    }
}