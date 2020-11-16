// Create a phone lookup program. You should have the ability to add, delete, and find phones number.
// The key will be a person’s name, for the example use just a first name and this will retrieve a person’s phone number. 

using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int MainMenuChoice = -1;

            Dictionary<string, long> directory = new Dictionary<string, long>();
            directoryTest(directory);


            while (MainMenuChoice != 0)
            {
                Console.WriteLine("1) Add Phone Number");
                Console.WriteLine("2) Delete Phone Number");
                Console.WriteLine("3) Find by Name");
                Console.WriteLine("4) Check Directory\n");
                Console.WriteLine("0) Exit Program\n");

                MainMenuChoice = int.Parse(Console.ReadLine());
                switch (MainMenuChoice)
                {
                    case (1):
                        string name;
                        long number;
                        Console.WriteLine("Adding name and number to directory:");
                        Console.Write("name: ");
                        name = Console.ReadLine();
                        Console.Write("number: ");
                        number = long.Parse(Console.ReadLine());
                        try
                        {
                            Console.WriteLine($"{name} : {number}");
                            directory.Add(name, number);
                        } catch(ArgumentException)
                        {
                            Console.WriteLine($"Name \"{name}\" already exists");
                            Console.WriteLine("Please try another name\n");
                        }
                        break;
                    case (2):
                        string deleteName;
                        int deleteChoice = -1;
                        Console.WriteLine("Who would you like to delete from the directory?");
                        deleteName = Console.ReadLine();
                        directory.Remove(deleteName);
                        Console.WriteLine("\n");
                        break;
                    case (3):
                        string findName;
                        Console.WriteLine("Who's number would you like to look up?");
                        findName = Console.ReadLine();
                        try
                        {
                            Console.WriteLine($"{findName} : {directory[findName]}");
                        }
                        catch (KeyNotFoundException)
                        {
                            Console.WriteLine($"{findName} not found");
                        }
                        Console.WriteLine("\n");
                        break;
                    case (4):
                        Console.WriteLine("Opening Directory");
                        foreach (KeyValuePair<string, long> kvp in directory)
                        {
                            Console.WriteLine("{0} : {1}",
                                kvp.Key, kvp.Value);
                        }
                        Console.WriteLine("\n");
                        break;
                    case (0):
                        Console.WriteLine("Exiting Program");
                        break;
                    default:
                        Console.WriteLine("Please Choose a valid menu option");
                        break;
                }
                
            }
        }
        public static void directoryTest(Dictionary<string, long> dict)
        {
            dict.Add("Bill", 8675309);
            dict.Add("Jane", 8675309);
            dict.Add("Bob", 3425577);
            dict.Add("Ted", 3422166);
        }
    }
}
