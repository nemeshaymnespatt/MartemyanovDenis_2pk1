using System;
using System.IO;

namespace pz_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ICESHINE\Desktop";
            string subpath = @"new";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);


            var myFile = File.Create(@"C:\Users\ICESHINE\Desktop\new\f2.txt");

            myFile.Close();

            File.AppendAllText(@"C:\Users\ICESHINE\Desktop\new\f2.txt", File.ReadAllText(@"C:\Users\ICESHINE\Desktop\f1.txt"));

        }
    }
}
