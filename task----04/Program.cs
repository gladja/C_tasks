using System;

namespace Hello
{
    class Program
    {

        static int[] InitByKeyBoard(int k, int n, string[] data)
        {
            // long sum = 0;
            // arr[1] = (long)x;

            int[] arr = new int[n];
            for (int i = 0; i < k; i++)
            {
                // string[] date = str.Trim().Split();
                for (int j = 0; i < arr.Length; j++)
                {
                    arr[j] = Int32.Parse(data[j]);
                }
                return arr;
            }
            return arr;
        }

        static void Sum(int[] arr)
        {
            // long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            // sum = arr[p] + arr[q] + arr[r];
            // Console.WriteLine($"{sum}");
        }





        static void Main(string[] args)

        {
            int k = Convert.ToInt16(Console.ReadLine());
            int n = Convert.ToInt16(Console.ReadLine());
            string[] data = Console.ReadLine().Trim().Split();
            // int p = int.Parse(data[0]);
            // int q = int.Parse(data[1]);
            // int r = int.Parse(data[2]);

            Sum(InitByKeyBoard(k, n, data));
        }
    }
}

