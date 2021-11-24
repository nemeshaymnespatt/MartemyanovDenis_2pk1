using System;

namespace ConsoleApp13
{

    class Program
    {
        static void Perimeter()
        {
            Random r = new Random();
            double[] v = new double[5];
            int[] r11 = new int[20];
            for (int i = 0; i < 20; i++)
            {
                r11[i] = r.Next(0, 10);
                Console.Write(r11[i] + " ");
            }
            Console.WriteLine("\n");
            double c = 0;
            for (int i = 1; i < 20; i += 4)
            {
                var a = 0;
                v[a] = Math.Sqrt((r11[i + 1] - r11[i - 1]) * (r11[i + 1] - r11[i - 1]) + (r11[i + 2] - r11[i]) * (r11[i + 2] - r11[i]));
                Console.WriteLine(v[a]);
                c += v[a];
                a++;
            }
            Console.WriteLine();
            Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            Perimeter();
        }
    }
}