using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] arr = new float[8, 6];
            float minValue;
            float sumPositive = 0;
            Random rand = new Random();

            for (int y = 0; y < arr.GetLength(1); y++)
            {
                for (int x = 0; x < arr.GetLength(0); x++)
                {
                    arr[x, y] = rand.Next(-99, 100);
                    Console.Write(arr[x, y] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            minValue = arr[0, 0];
            for (int y = 0; y < arr.GetLength(1); y++)
            {
                for (int x = 0; x < arr.GetLength(0); x++)
                {
                    if (arr[x, y] < minValue)
                    {
                        minValue = arr[x, y];
                    }

                    if (arr[x, y] > 0)
                    {
                        sumPositive += arr[x, y];
                    }
                }
            }

            Console.WriteLine($"Наименьшее число матрицы {minValue}");
            Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");
            Console.WriteLine($"Произведение наименьшего числа на сумму положительных равно {minValue * sumPositive}");
        }
    }
}

