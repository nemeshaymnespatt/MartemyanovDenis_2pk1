using System;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Вводите элементы");
            for (int i = 0; i < n; i++)
            {
                a [i] = Convert.ToInt32(Console.ReadLine());
            }
            int k = 0;
            Console.WriteLine("Четные числа: ");
            for (int i = n - 1; i >= 0; i--)
            {
                if (a[i] % 2 == 0)
                {
                    k = k + 1 ;
                    Console.Write(a [i]);
                    Console.Write(" ");
                }
            }
            Console.WriteLine("Количество чётных чисел: ");
            Console.WriteLine(k);
        }
    }
}
