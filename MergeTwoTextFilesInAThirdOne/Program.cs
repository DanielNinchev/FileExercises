using System;
using System.IO;
using System.Text;

namespace MergeTwoTextFilesInAThirdOne
{
    class Program
    {
        //Напишете програма, която съединява два текстови файла и записва резултата в трети файл.
        static void Main(string[] args)
        {
            string firstFile = "first.txt";
            string secondFile = "second.txt";
            string thirdFile = "third.txt";

            try
            {
                StreamWriter writer = new StreamWriter(thirdFile, false);
                using (writer)
                {
                    ReadFile(firstFile, thirdFile, writer);
                }

                writer = new StreamWriter(thirdFile, true);
                using (writer)
                {
                    ReadFile(secondFile, thirdFile, writer);
                }             
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine($"At least one of the two files could not be found.");
            }
        }

        public static void ReadFile(string file, string resultFile, StreamWriter writer)
        {
            StreamReader reader = new StreamReader(file);

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
