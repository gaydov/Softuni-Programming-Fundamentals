using System;
using System.IO;

namespace OddLines
{
    public class Launcher
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("Input.txt");

            if (File.Exists("Output.txt"))
            {
                File.Delete("Output.txt");
            }

            for (int i = 1; i < text.Length; i += 2)
            {
                File.AppendAllText("Output.txt", text[i] + Environment.NewLine);
            }
        }
    }
}
