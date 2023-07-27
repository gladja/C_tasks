using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {

            int num = Convert.ToInt32(Console.ReadLine());
            int nextNum = num + 1;
            int prevNum = num - 1;

            Console.WriteLine("The next number for {0} is {1}.", num, nextNum);
            Console.WriteLine("The previous number for {0} is {1}.", num, prevNum);
        }
    }
}