using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            float otvet = 1;
            while (n >= 2) 
            {
                n -= 2;
                otvet *= n;
            }
            Console.WriteLine(otvet);
        }
    }
}
