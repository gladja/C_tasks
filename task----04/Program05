using System;

namespace Hello
{
    class Program
    {

        static int[] InitByKeyBoard(string str)
        {
            string[] date = str.Trim().Split();
            int[] arr = new int[date.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(date[i]);
            }
            return arr;
        }

        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        static void CountOfDifferent(int[] arr)
        {
            double max = 0;
            double count = 0;
            double value = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (IsPrime(Math.Abs(arr[i])) && Math.Abs(arr[i]) != 1 && arr[i] != 0)
                {
                    // Console.WriteLine(arr[i]);
                    value += arr[i];
                    count++;
                    max = value / count;
                }

            }
            if (max == 0)
            {
                Console.WriteLine(max);
            }
            else
            {
                Console.WriteLine("{0:F4}", max);
            }
        }

        static void Main(string[] args)

        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());

            CountOfDifferent(myArr);
        }
    }
}

