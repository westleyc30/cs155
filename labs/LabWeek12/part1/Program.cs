using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hi");
            Dictionary<string, NamePopularity> boysNames = new Dictionary<string, NamePopularity>();
            Dictionary<string, NamePopularity> girlsNames = new Dictionary<string, NamePopularity>();

            
            
            try
            {
                string line;
                int count = 1;
                StreamReader sr = new StreamReader("./files/boynames.txt");
                line = sr.ReadLine();
                
                while (line != null)
                {
                    string[] namePop = line.Split(' ');

                    boysNames.Add(namePop[0], new NamePopularity(int.Parse(namePop[1]), count));
                    //Console.WriteLine(namePop[0] + " " + int.Parse(namePop[1]));
                    //Console.WriteLine(count);

                    line = sr.ReadLine();
                    count++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: ${e.Message}");
                throw;
            }

            try
            {
                string line;
                int count = 1;
                StreamReader sr = new StreamReader("./files/girlnames.txt");
                line = sr.ReadLine();

                while (line != null)
                {
                    string[] namePop = line.Split(' ');

                    girlsNames.Add(namePop[0], new NamePopularity(int.Parse(namePop[1]), count));
                    //Console.WriteLine(namePop[0] + " " + int.Parse(namePop[1]));
                    //Console.WriteLine(count);

                    line = sr.ReadLine();
                    count++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: ${e.Message}");
                throw;
            }


            int choice = -1;

            while(choice != 2)
            {
                Console.WriteLine("Please choose a menu option:\n");
                Console.WriteLine("1. Search a name");
                Console.WriteLine("2. Exit Program");
                string optionChoice = Console.ReadLine();
                choice = int.Parse(optionChoice);

                string searchName;

                if(choice == 1)
                {
                    Console.WriteLine("please enter a name to search");
                    searchName = Console.ReadLine();
                    //Console.WriteLine(boysNames[searchName].count);
                    try
                    {
                        
                        Console.WriteLine($"{searchName} is ranked {girlsNames[searchName].rank} in popularity amonst girls with {girlsNames[searchName].count}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{searchName} is not ranked in the top 1000 girls names");
                    }
                    try
                    {
                        
                        Console.WriteLine($"{searchName} is ranked {boysNames[searchName].rank} in popularity amonst boys with {boysNames[searchName].count}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{searchName} is not ranked in the top 1000 boys names");
                    }
                } else
                {
                    Console.WriteLine("Please enter one of the menu options");
                }
            }

            
            
        }
    }
}
