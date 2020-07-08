using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace LINQFundamentalsLibrary
{
    public class HelperClass
    {
        /// <summary>
        /// Ausgabe von Files ohne Linq
        /// </summary>
        /// <param name="path"></param>
        public static void ShowLargeFilesWithoutLinq(string path)
        {

            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();

            //Sort benötigt ein Comparer...
            Array.Sort(files, new FileInfoComparer());
            foreach(FileInfo file in files)
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }
        }

        /// <summary>
        /// Ausgabe von Files mit Linq
        /// </summary>
        /// <param name="path"></param>
        public static void ShowLargeFilesWithLinq(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;

            //var query = new DirectoryInfo(path).GetFiles().OrderByDescending(f => f.Length).Take(5);

            foreach (var file in query)
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }
        }
    }

    /// <summary>
    /// Klasse zum Verglechen erstellt
    /// </summary>
    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }

}
