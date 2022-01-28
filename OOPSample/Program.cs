using System;
using OOPSample.Helpers;
using OOPSample.Models;

namespace OOPSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log = Log.GetInstance();
            log.LogProperty = "#1 Test";
            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.LogProperty);

            /*
            var pathing = "C:\\FilesOnCSharp";
            HFile helping = new HFile();
            helping.DirectoryList(pathing);
            */
        }
    }
}
