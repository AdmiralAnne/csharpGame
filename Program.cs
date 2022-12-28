// See https://aka.ms/new-console-template for more information
using System;

namespace UserInputExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for input
            Console.Write("Enter your name: ");

            // Read the user's input
            string name = Console.ReadLine();

            // Output the user's input
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
