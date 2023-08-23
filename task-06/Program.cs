using System;

public class Test
{

    static int[,] InitByKeyBoardLine(int n)
    {
        int[,] arr = new int[n, n];
        // int m = n;
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                arr[i, j] = 0;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (!(i == 0 || i == n - 1 || j == 0 || j == n - 1))
                {

                }
                continue;      // Временное условие для фильтрации элементов внесшего "кольца"
                int a = i + 1;     // Номера строк и столбцов приводим в удобный
                int b = j + 1;     // в математическом плане вид (от 1 до N)  
                                   //  ... здесь будем вставлять основной код вычислений
            }
        }


        return arr;
    }

    static void NewArr(int[,] arr)
    {

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)

    {
        // string[] data = Console.ReadLine().Trim().Split();
        // int n = int.Parse(data[0]);
        // int m = int.Parse(data[1]);
        int n = Convert.ToInt16(Console.ReadLine());

        NewArr(InitByKeyBoardLine(n));
    }
}

