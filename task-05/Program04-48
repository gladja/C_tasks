using System;

namespace Hello
{
    class Program
    {

        static int[] InitByKeyBoard(int n)
        {
            int[] arr = new int[n + n];
            int count = 2;

            for (int i = 1; i <= n; i++)
            {
                arr[i] = (int)Math.Pow(i, 2);
                // Console.WriteLine($"one {arr[i]}");
            }
            for (int i = n + 1; i < arr.Length; i++)
            {
                arr[i] = (int)Math.Pow(count, 3);
                // Console.WriteLine($"two {arr[i]}");
                count++;
            }
            return arr;
        }

        static int[] CountOfDifferent(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            return arr;
        }

        static void Created(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    arr[i + 1] = arr[i + 2];
                }
            }
            Array.Resize(ref arr, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            if (n == 1)
            {
                Console.WriteLine($"1");
            }
            else
            {
                // Console.WriteLine($"{arr[n]} ");
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());

            Created(CountOfDifferent(InitByKeyBoard(n)), n);
        }
    }
}