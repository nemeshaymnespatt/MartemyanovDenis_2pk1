using System;
using System.Threading;
using System.Linq;

namespace pz_12
{
    class Program
    {
        static void Main()
        {
            string[] str = new string[4];
            str[0] = "123";
            str[1] = "456";
            str[2] = "789";
            str[3] = "000";


            var zxc = str.OrderBy(a => a.Length);

            foreach (string item in zxc)
                Console.WriteLine(item);
        }
    }
}