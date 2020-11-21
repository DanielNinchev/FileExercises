using System;
using System.IO;

namespace InsertLineNumbersInAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "alphabet.txt";
            string[] lines = File.ReadAllLines(file);

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = $"{i + 1}. {lines[i]}";    
            }

            File.WriteAllLines(file, lines);
        }
    }
}
