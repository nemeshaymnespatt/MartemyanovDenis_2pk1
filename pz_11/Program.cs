using System;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string b = Console.ReadLine();
            Char C = Convert.ToChar(b);
            string result = S.Replace("" + C, "" + C + C);
            Console.WriteLine(result);

        }
    }
}
