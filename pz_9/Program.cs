using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = y = z = 0;
            int[,] a = new int[8, 6];
            int[] b = new int[48];
            Random q = new Random();
            for (int i = 0; i != 8; i++)
            {
                for (int j = 0; j != 6; j++)
                {
                    a[i, j] = q.Next(int.MinValue, int.MaxValue);
                    Console.Write($"{a[i, j]} \t");
                    if (a[i, j] > 0)
                    {
                        b[x] = a[i, j];
                        x++;
                    }
                    else if (a[i, j] < z)
                    {
                        z = a[i, j];
                    }
                }
                Console.WriteLine();
            }
            while (x != 0)
            {
                y += b[x];
                x--;
            }
            Console.WriteLine($"Ответ: {y * z}");
            Console.ReadLine();
        }
    }
}
