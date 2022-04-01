using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Week9
{
    class Program
    {
        static void Main(string[] args)
        {
            



            /*var ReadFile = File.ReadAllText(@"D:\Wk9Test\Test.txt");
            var str = ReadFile.Split(new char[] {'\n'},
            StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Number of Words:" + str.Length);*/

            

            try
            {
                Console.WriteLine("Enter your file:");

                string input = Console.ReadLine();

                var numChecker = new Regex(@"");

                StreamReader sr = new StreamReader(input); // @"D:\Wk9Test\Test.txt"
                string text = sr.ReadToEnd();

                Console.WriteLine(text);

                var str = text.Split(new char[] { ' ', '\n' },
                StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine("Number of Words:" + str.Length);
            }

            catch(FormatException)
            {
                Console.WriteLine("The file was invalid.");
            }

            catch(Exception e)
            {
                Console.WriteLine(e.GetType() + ": " + e.Message);
            }
        }
    }
}
