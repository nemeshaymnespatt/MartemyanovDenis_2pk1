using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("zadanie 1");
                for (int i = -50; i < 60; i += 10)
                {
                    Console.WriteLine(i); 
                }
            }
            {
                Console.WriteLine("zadanie 2");
                for (int i = 0; i < 6; i += 1)
                {
                    Console.Write($"{(char)(i + 'N')}\t");
                }
                {
                    Console.WriteLine("zadanie 3");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(new string('#', 4));
                    }
                    {
                        Console.WriteLine("zadanie 4");
                        for (int i = 0; i <= 100; i += 5)
                        {
                            Console.WriteLine(i);
                        }
                        {
                            Console.WriteLine("zadanie 5");
                            for (int i = 4, j = 50; Math.Abs(i - j) != 22; i++, j--)
                            {
                                Console.WriteLine("{0} {1}", i, j);
                            }
                        }
                    }
                }
            }
            
        }
    }
}
