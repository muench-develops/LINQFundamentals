using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace LINQFundamentalsLibrary
{

    /// <summary>
    /// Class for Comparer
    /// </summary>
    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }

    public class HelperClass
    {
        /// <summary>
        /// Shows Files without Linq
        /// </summary>
        /// <param name="path">Path to directory</param>
        public static void ShowFilesWithoutLinq(string path)
        {

            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            
            Array.Sort(files, new FileInfoComparer());

            foreach(FileInfo file in files)
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }
        }

        /// <summary>
        /// Shows Files with Linq
        /// </summary>
        /// <param name="path">Path to directory</param>
        public static void ShowFilesWithLinq(string path)
        {
            //var query = from file in new DirectoryInfo(path).GetFiles()
            //            orderby file.Length descending
            //            select file;
            
            var query = new DirectoryInfo(path).GetFiles().OrderByDescending(f => f.Length);

            foreach (var file in query)
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }
        }
    }

}
