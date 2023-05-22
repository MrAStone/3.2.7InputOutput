using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._7InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Be able to obtain user input from the keyboard.
            string userInput;
            Console.Write("Enter something: "); // write without moving onto the next line
            userInput = Console.ReadLine(); // take an input (always a string in C#)

            // Be able to output data and information from a
            // program to the computer display.
            Console.WriteLine(userInput); // write and move on to the next line
            

        }
    }
}
