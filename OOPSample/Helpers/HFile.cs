using System.IO;

namespace OOPSample.Helpers
{
    public class HFile
    {
        public void DirectoryList(string pathing)
        {
            var pathAnswer = Directory.GetDirectories(pathing,"*",SearchOption.AllDirectories);
            foreach (var inner in pathAnswer)
            {
                System.Console.WriteLine(inner);
            }
        }   
        
        public void FileAndDirectoryList(string pathing)
        {
            var pathAnswer = Directory.GetFiles(pathing,"*",SearchOption.AllDirectories);
            foreach (var inner in pathAnswer)
            {
                System.Console.WriteLine(inner);
            }
        }   
        
        public void CreateDirectory(string pathing)
        {
            var pathAnswer = Directory.CreateDirectory(pathing);
            System.Console.WriteLine(pathAnswer.FullName);
        }   
        
        public void DeleteDirectory(string pathing)
        {
            Directory.Delete(pathing);
        }   
        
        public void CreateTextFile(string pathing, string content)
        {
            File.WriteAllText(pathing, content);
        }   




    }
}