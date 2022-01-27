using System;
using OOPSample.Helpers;
using OOPSample.Models;

namespace OOPSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathing = "C:\\FilesOnCSharp";
            HFile helping = new HFile();
            helping.DirectoryList(pathing);
        }
    }
}
