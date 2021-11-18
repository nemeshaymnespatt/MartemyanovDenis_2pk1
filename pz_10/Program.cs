using System;
using System.Linq;
namespace pz_10
{
    class Program
    {
        static void n1(string a)
        {
            Console.WriteLine(a);
        }

        static void n2(string a)
        {
           
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            Random zxc = new Random();
            char[][] myArray = new char[10][];
            char[] myArray0 = new char[10];
            int a = 0;
            char b = ' ';
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new char[zxc.Next(3, 50)];
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = (char)zxc.Next(128);
                }
            }
            n2("array: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                    Console.Write($"{myArray[i][j]} ");
                n1($"\n\t\t\t—\n");
            }
            for (int i = 0; i != 10; i++)
                myArray0[i] = myArray[i][^1];
            n2("last: ");
            for (int i = 0; i != 10; i++)
                Console.Write($"{myArray0[i]} ");
            n1("\n");
            for (int i = 0; i != 10; i++)
                myArray0[i] = myArray[i].Max();
            n2("max: ");
            for (int i = 0; i != 10; i++)
                Console.Write($"{myArray0[i]} ");
            n1("\n");
            for (int i = 0; i != 10; i++)
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    if (myArray[i][j] == myArray[i].Max())
                    {
                        a = Array.IndexOf(myArray[i], myArray[i][j]);
                        b = myArray[i][0];
                        myArray[i][0] = myArray[i].Max();
                        myArray[i][a] = b;
                    }
                }
            n2("new: ");
            for (int i = 0; i != 10; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                    Console.Write($"{myArray[i][j]} ");
                n1($"\n\t\t\t—\n");
            }
        }
    }
}