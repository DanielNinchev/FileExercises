using System;
using System.IO;

namespace DeleteOddLinesFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "names.txt";

            string[] lines = File.ReadAllLines(file);

            int counter = 0;

            try
            {
                StreamWriter writer = new StreamWriter(file, false);

                using (writer)
                {
                    foreach (var line in lines)
                    {
                        counter++;

                        if (counter % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine($"The file {file} could not be found.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine($"The file {file} could not be read.");
            }
        }
    }
}
