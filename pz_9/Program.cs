using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] arr1 = new float[8, 6];
            float minValue;
            float sumPositive = 0;
            Random rand = new Random();

            for (int y = 0; y < arr1.GetLength(1); y++)
            {
                for (int x = 0; x < arr1.GetLength(0); x++)
                {
                    arr1[x, y] = rand.Next(-99, 100);
                    Console.Write(arr1[x, y] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            minValue = arr1[0, 0];
            for (int y = 0; y < arr1.GetLength(1); y++)
            {
                for (int x = 0; x < arr1.GetLength(0); x++)
                {
                    if (arr1[x, y] < minValue)
                    {
                        minValue = arr1[x, y];
                    }

                    if (arr1[x, y] > 0)
                    {
                        sumPositive += arr1[x, y];
                    }
                }
            }

            Console.WriteLine($"Наименьшее число матрицы {minValue}");
            Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");
            Console.WriteLine($"Произведение наименьшего числа на сумму положительных равно {minValue * sumPositive}");
        }
    }
}

