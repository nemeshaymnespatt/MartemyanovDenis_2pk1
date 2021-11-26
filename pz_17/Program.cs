using System;

namespace ConsoleApp13
{

    class Program
    {
        static bool Formule(string abc)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < abc.Length; i++)
            {
                if (abc[i] == '(')
                {
                    a++;
                }
                if (abc[i] == ')')
                {
                    b++;
                }
            }
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            string abc = "(a^2)-(b^2) = (a-b)(a+b)";
            Console.WriteLine(abc);
            Console.WriteLine(Formule(abc));
        }
    }
}