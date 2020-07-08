using LINQFundamentalsLibrary;
using System;

namespace LINQFundamentalsUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\";

            HelperClass.ShowFilesWithoutLinq(path);

            Console.WriteLine("****************************");

            HelperClass.ShowFilesWithLinq(path);
            Console.ReadLine();
        }
    }
}
