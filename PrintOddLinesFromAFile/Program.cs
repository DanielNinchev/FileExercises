using System;
using System.IO;

namespace PrintOddLinesFromAFile
{
    class Program
    {
        //Напишете програма, която чете от текстов файл и отпечатва нечетните му редове на конзолата.
        static void Main(string[] args)
        {
            string fileName = "text.txt";
            int counter = 0;

            try
            {
                StreamReader reader = new StreamReader(fileName);

                using (reader)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        counter++;

                        if (counter % 2 != 0)
                        {
                            Console.WriteLine(line);
                        }

                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine($"The file {fileName} could not be found.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Cannot read the file {0}.", fileName);
            }
        }
    }
}
