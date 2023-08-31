using System;

public class Test
{

    static void Result(int n, string data)
    {
        int count = 0;
        int sum = 0;

        for (int i = 0; i < data.Length; i++)
        {
            if ((byte)data[i] >= 48 && (byte)data[i] <= 57)
            {
                count++;
                sum += (data[i] - 48);
            }
        }
        Console.Write($"{count}\n{sum}");
    }

    static void Main(string[] args)

    {
        int n = Convert.ToInt16(Console.ReadLine());
        string data = Console.ReadLine();

        Result(n, data);
    }

}