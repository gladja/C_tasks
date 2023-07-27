using System;

namespace task_16
{
    class Program
    {
        static void Main()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 0)
            {
                int a = num1 / 100;
                int b = (num1 / 10) % 10;
                int c = num1 % 10;

                if ((a != b) && (a != c) && (b != c))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

            if (num2 > 0)
            {
                int a = num2 / 100;
                int b = (num2 / 10) % 10;
                int c = num2 % 10;

                if ((a != b) && (a != c) && (b != c))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

            if (num3 > 0)
            {
                int a = num3 / 100;
                int b = (num3 / 10) % 10;
                int c = num3 % 10;

                if ((a != b) && (a != c) && (b != c))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

            if (num4 > 0)
            {
                int a = num4 / 100;
                int b = (num4 / 10) % 10;
                int c = num4 % 10;

                if ((a != b) && (a != c) && (b != c))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

            if (num5 > 0)
            {
                int a = num5 / 100;
                int b = (num5 / 10) % 10;
                int c = num5 % 10;

                if ((a != b) && (a != c) && (b != c))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }


        }
    }
}
