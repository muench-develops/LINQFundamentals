using LINQFundamentalsLibrary;
using System;

namespace LINQFundamentalsUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\JustinM\Desktop\SQL";
            HelperClass.ShowLargeFilesWithoutLinq(path);
            Console.WriteLine("****");
            HelperClass.ShowLargeFilesWithLinq(path);
            Console.ReadLine();
        }
    }
}
