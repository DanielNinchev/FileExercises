using System;
using System.IO;

namespace CountingASubstringInAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се преброи колко пъти се среща поднизът "С#" в текстов файл.

            string fileName = @"..\..\sample.txt";
            string word = "C#";

            try
            {
                StreamReader reader = new StreamReader(fileName);

                using (reader)
                {
                    int occurrences = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        int index = line.IndexOf(word);

                        while (index != -1)
                        {
                            occurrences++;
                            index = line.IndexOf(word, (index + 1));
                        }

                        line = reader.ReadLine();
                    }

                    Console.WriteLine($"The word {word} occurs {occurrences} times in the file.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Cannot find file {0}.", fileName);
            }
            catch(IOException)
            {
                Console.Error.WriteLine("Cannot read the file {0}.", fileName);
            }
        }
    }
}
