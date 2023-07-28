using System;

namespace task_05
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            // int num2 = Convert.ToInt32(Console.ReadLine());
            // int num3 = Convert.ToInt32(Console.ReadLine());
            // int num4 = Convert.ToInt32(Console.ReadLine());
            // int num5 = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            // int sum2 = 0;
            // int sum3 = 0;
            // int sum4 = 0;
            // int sum5 = 0;

            if (num > 99 && num < 1000)
            {
                int a = num / 100;
                int b = num % 100 / 10;
                int c = num % 10;

                if (a == 0 || b == 0 || c == 0)
                {
                    sum += 1;
                }
            }

            if (num > 999 && num < 10000)
            {
                int a = num / 1000;
                int b = num % 1000 / 100;
                int c = num % 100 / 10;
                int d = num % 10;

                if ((a != b && a != b && a != d && b != c && b != d && c != d))
                {
                    sum += 1;
                }
            }

            if (num % 10 == 3 || num % 10 == 6 || num % 10 == 9)
            {
                sum += 1;
            }

            if (sum == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


            // if (num2 > 99 && num2 < 1000)
            // {
            //     int a = num2 / 100;
            //     int b = (num2 / 10) % 10;
            //     int c = num2 % 10;

            //     if (a == 0 || b == 0 || c == 0)
            //     {
            //         sum2 += 1;
            //     }

            // }

            // if (num2 > 999 && num2 < 10000)
            // {
            //     int a = num2 / 1000;
            //     int b = (num2 / 100) % 10;
            //     int c = (num2 / 10) % 10;
            //     int d = num2 % 10;

            //     if ((a != b && a != b && a != d && b != c && b != d && c != d))
            //     {
            //         sum2 += 1;
            //     }
            // }

            // if (num2 % 10 == 3 || num2 % 10 == 6 || num2 % 10 == 9)
            // {
            //     sum2 += 1;
            // }

            // if (sum2 == 1)
            // {
            //     Console.WriteLine("YES");
            // }
            // else
            // {
            //     Console.WriteLine("NO");
            // }


            // if (num3 > 99 && num3 < 1000)
            // {
            //     int a = num3 / 100;
            //     int b = (num3 / 10) % 10;
            //     int c = num3 % 10;

            //     if (a == 0 || b == 0 || c == 0)
            //     {
            //         sum3 += 1;
            //     }

            // }

            // if (num3 > 999 && num3 < 10000)
            // {
            //     int a = num3 / 1000;
            //     int b = (num3 / 100) % 10;
            //     int c = (num3 / 10) % 10;
            //     int d = num3 % 10;

            //     if ((a != b && a != b && a != d && b != c && b != d && c != d))
            //     {
            //         sum3 += 1;
            //     }
            // }

            // if (num3 % 10 == 3 || num3 % 10 == 6 || num3 % 10 == 9)
            // {
            //     sum3 += 1;
            // }

            // if (sum3 == 1)
            // {
            //     Console.WriteLine("YES");
            // }
            // else
            // {
            //     Console.WriteLine("NO");
            // }


            // if (num4 > 99 && num4 < 1000)
            // {
            //     int a = num4 / 100;
            //     int b = (num4 / 10) % 10;
            //     int c = num4 % 10;

            //     if (a == 0 || b == 0 || c == 0)
            //     {
            //         sum4 += 1;
            //     }

            // }

            // if (num4 > 999 && num4 < 10000)
            // {
            //     int a = num4 / 1000;
            //     int b = (num4 / 100) % 10;
            //     int c = (num4 / 10) % 10;
            //     int d = num4 % 10;

            //     if ((a != b && a != b && a != d && b != c && b != d && c != d))
            //     {
            //         sum4 += 1;
            //     }
            // }

            // if (num4 % 10 == 3 || num4 % 10 == 6 || num4 % 10 == 9)
            // {
            //     sum4 += 1;
            // }

            // if (sum4 == 1)
            // {
            //     Console.WriteLine("YES");
            // }
            // else
            // {
            //     Console.WriteLine("NO");
            // }

            // if (num5 > 99 && num5 < 1000)
            // {
            //     int a = num5 / 100;
            //     int b = (num5 / 10) % 10;
            //     int c = num5 % 10;

            //     if (a == 0 || b == 0 || c == 0)
            //     {
            //         sum5 += 1;
            //     }

            // }

            // if (num5 > 999 && num5 < 10000)
            // {
            //     int a = num5 / 1000;
            //     int b = (num5 / 100) % 10;
            //     int c = (num5 / 10) % 10;
            //     int d = num5 % 10;

            //     if ((a != b && a != b && a != d && b != c && b != d && c != d))
            //     {
            //         sum5 += 1;
            //     }
            // }

            // if (num5 % 10 == 3 || num5 % 10 == 6 || num5 % 10 == 9)
            // {
            //     sum5 += 1;
            // }

            // if (sum5 == 1)
            // {
            //     Console.WriteLine("YES");
            // }
            // else
            // {
            //     Console.WriteLine("NO");
            // }
        }
    }
}
