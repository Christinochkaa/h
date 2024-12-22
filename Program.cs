using System;

class Program
{
    static void Main()
    {
        int[] sequence = { 1, 2, 3, 4, 5, 100, 50, 25, 75, 10, 90, 80, 70, 60, 55, 45, 40, 30, 20, 15 };

        int maxSumOfSquares = 0;

        int length = sequence.Length;

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 10; j < length; j++)
            {
                int sumOfSquares = sequence[i] * sequence[i] + sequence[j] * sequence[j];

                if (sumOfSquares > maxSumOfSquares)
                {
                    maxSumOfSquares = sumOfSquares;
                }
            }
        }

        Console.WriteLine("Максимальная сумма квадратов: " + maxSumOfSquares);
    }
}