// Ray de Groat - Lexicon AB - May 17, 2020
// Assignment 5: Read files/ Mix and Sort - Create a program to read two
// different files and display the contents mixed and sorted alphabetically.

using System;
using System.IO;
using System.Linq;

namespace ReadSort
{
    class Program
    {

        static void displayFile(string[] array)                         // Print each array element to the screen
        {
            foreach (string s in array) 
            {
                Console.WriteLine(s);
            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.Write("Enter the path to file 1: ");               // Get the path to each of the files
            string file1 = Console.ReadLine();
            Console.Write("Enter the path to file 2: ");
            string file2 = Console.ReadLine();
            Console.WriteLine();

            string[] readText1 = File.ReadAllLines(file1);             // Each line of text becomes an element of a string array
            string[] readText2 = File.ReadAllLines(file2); 

            System.Console.WriteLine("File 1 Unsorted:");              // display each file unsorted
            System.Console.WriteLine();
            displayFile(readText1);
            Console.WriteLine();
            Console.WriteLine("File 2 Unsorted");
            Console.WriteLine();
            displayFile(readText2);
            Console.WriteLine();

            string[] catArray = readText1.Concat(readText2).ToArray(); // Concatinate the arrays

            System.Console.WriteLine("Files 1 and 2 combined and sorted");
            Console.WriteLine();
            Array.Sort(catArray);                                      // Sort the concatinated arrays
            displayFile(catArray);                                     // Display the newly sorted contatinated array
            Console.WriteLine();
        }
    }
}
