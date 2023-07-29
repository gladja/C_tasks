using System;

namespace task_13
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine(num);
            // Console.WriteLine(num1);
            // Console.WriteLine(num - num1);
            // if 
            // double a = num / 1000;
            // Console.WriteLine(a);
            // double b = num % 1000 / 100;
            // Console.WriteLine(b);
            // double c = num % 100 / 10;
            // Console.WriteLine(c);
            // double d = num % 10;
            // Console.WriteLine(d);
            //1
            if (num <= 9)
            {
                Console.WriteLine(num);
            }
            //2
            if (num > 9 && num <= 99)
            {
                int a = num / 10;
                int b = num % 10;
                Console.WriteLine(b);
            }
            //3
            if (num > 99 && num <= 999)
            {
                int a = num / 100;
                int b = (num / 10) % 10;
                int c = num % 10;
                Console.WriteLine(a);
            }
            //4
            if (num > 999 && num <= 9999)
            {
                int a = num / 1000;
                int b = (num / 100) % 10;
                int c = (num / 10) % 10;
                int d = num % 10;
                Console.WriteLine(d);
            }
            //5
            if (num > 9999 && num <= 99999)
            {
                int a = num / 10000;
                int b = (num / 1000) % 10;
                int c = (num / 100) % 10;
                int d = (num / 10) % 10;
                int e = num % 10;
                Console.WriteLine(e);
            }
        }
    }
}




