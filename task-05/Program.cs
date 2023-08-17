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

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    // Console.WriteLine($"i:{arr[i]} j:{arr[j]}");
                    if (arr[j + 1] > arr[j])
                    {
                        int t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            return arr;
        }

        static void Created(int[] arr, int[] arrCopy)
        {
            int value = 0;
            int valueTwo = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                // if (arr[i] > arr[i + 1])
                // {
                // Console.Write($"{arr[i + 1]} ");
                value = arr[i];
                // break;
                // }
                // Console.Write($"{arr[i]} ");
                for (int j = 0; j < arrCopy.Length; j++)
                {

                    if (arrCopy[j] == value)
                    {
                        // Console.Write($"{j + 1} ");
                        count++;
                        if (count < 2)
                        {
                            valueTwo = j + 1;
                        }
                        if (count > 1)
                        {
                            valueTwo = j + 1;
                        }
                    }
                    // Console.Write($"{arrCopy[i]} ");
                }
                count = 0;
                Console.Write($"{valueTwo} ");
            }

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());
            int[] arrCopy = new int[myArr.Length];
            Array.Copy(myArr, arrCopy, myArr.Length);

            Created(CountOfDifferent(myArr), arrCopy);
            // CreatedTwo(arrCopy);
        }
    }
}