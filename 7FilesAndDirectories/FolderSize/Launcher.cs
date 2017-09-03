using System;
using System.IO;

namespace FolderSize
{
    public class Launcher
    {
        public static void Main()
        {
            string[] directoryFiles = Directory.GetFiles("TestFolder");
            double size = 0;

            foreach (string file in directoryFiles)
            {
                FileInfo info = new FileInfo(file);
                size += info.Length;
            }

            size = size / 1024 / 1024;

            Console.WriteLine(size);
        }
    }
}
