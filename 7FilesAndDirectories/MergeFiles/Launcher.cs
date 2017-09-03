using System;
using System.IO;

namespace MergeFiles
{
    public class Launcher
    {
        public static void Main()
        {
            string[] firstFile = File.ReadAllLines("FileOne.txt");
            string[] secondFile = File.ReadAllLines("FileTwo.txt");

            if (File.Exists("result.txt"))
            {
                File.Delete("result.txt");
            }

            for (int i = 0; i < firstFile.Length; i++)
            {
                File.AppendAllText("result.txt", firstFile[i] + Environment.NewLine + secondFile[i] + Environment.NewLine);
            }
        }
    }
}
