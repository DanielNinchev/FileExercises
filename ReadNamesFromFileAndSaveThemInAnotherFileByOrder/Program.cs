using System;
using System.Collections.Generic;
using System.IO;

namespace ReadNamesFromFileAndSaveThemInAnotherFileByOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "names.txt";
            string result = "ordered names.txt";

            List<string> names = new List<string>();

            try
            {
                StreamReader reader = new StreamReader(file);

                using (reader)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        names.Add(line);
                        line = reader.ReadLine();
                    }
                }

                StreamWriter writer = new StreamWriter(result, false);

                names.Sort();

                using (writer)
                {
                    foreach (var name in names)
                    {
                        writer.WriteLine(name);
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
