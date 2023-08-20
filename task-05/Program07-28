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

        static int[] CountOfDifferent(int[] arr)
        {
            int temp = 0;
            int first = 0;
            int count = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                // smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // Console.WriteLine($"i:{arr[i]} j:{arr[j]}");
                    if (arr[first] > arr[j])
                    {
                        first = j;
                        count++;
                    }

                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine($"{count}");
            return arr;
        }

        static void Created(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        static void Main(string[] args)

        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());

            // Created(CountOfDifferent(myArr));
            CountOfDifferent(myArr);
        }
    }
}

