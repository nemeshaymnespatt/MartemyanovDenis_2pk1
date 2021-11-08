using System;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "This is a test";
            Char C = 's';
            string result = S.Replace("" + C, "" + C + C);
            Console.WriteLine(result);

        }
    }
}
