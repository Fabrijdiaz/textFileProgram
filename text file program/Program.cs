using System;
using System.IO;
using System.Text.RegularExpressions;

namespace text_file_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a file path: ");

            string fp = @"" + Console.ReadLine();

            var numChecker = new Regex(@"^[A-Z]:\\([A-Za-z0-9]+\s*\\*)+.txt$");

            if(numChecker.IsMatch(fp))
            {
                Console.WriteLine("File path is valid");
                try
                {
                    StreamReader sr = new StreamReader(fp);
                    int counter = 0;
                    string line;
                    Console.WriteLine("Opening the file...");
                    do
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            Console.WriteLine(line);
                            string[] subs = line.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
                            counter += subs.Length;
                            Console.WriteLine("There are " + counter + " words in the file");
                        }
                    } while (line != null);
                }
                catch
                {
                    Console.WriteLine("Unfortunetly, that file does not exist");
                }
            }

            else
            {
                Console.WriteLine("Not a valid file path!");
            }
        }
    }
}