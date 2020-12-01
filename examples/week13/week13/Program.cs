using System;
using System.IO;

namespace week13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Sample.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: ${e.Message}");
                throw;
            }
            */

            // Writing into a file
            /*
            try
            {
                StreamWriter sw = new StreamWriter("SampleForWriting.txt");
                sw.WriteLine("I'm writing to a text file");
                sw.WriteLine("The end of the writing");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: ${e.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine("no errors");
            }
            */
            int x;
            try
            {
                StreamWriter sw = new StreamWriter("SampleWriting2.txt");
                for (x = 0; x <= 10; x++)
                {
                    sw.Write(x);

                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("no errors");
                throw;
            }
            finally
            {
                Console.WriteLine("written");
            }
        }
    }
}
