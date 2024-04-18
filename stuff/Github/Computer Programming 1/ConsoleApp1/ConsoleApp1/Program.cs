using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To get input from the user First we Prompt
            Console.WriteLine("Please enter your name");
            //Use Console.ReadLine() and store it into a variable. (Console.ReadLine() will always return a String)
            String name = Console.ReadLine()
            Console.WriteLine("Your name is: " + name);
            //Return the string name
            Console.WriteLine("Please enter your age");
            String ageString = Console.ReadLine();
            //Use a Parse to convert string to the age
            int age = int.Parse(ageString);
            //Calculate their age in 2029
            int ageIn2029 = age + 5;
            Console.WriteLine("In 2029 you will be: " + ageIn2029);

            //As an exercise
            //Declare 3 doubles
            //Get values from the user and output the sum of the numbers

            //Use a Console.ReadLine() to keep the terminal open
            Console.ReadLine();

        }
    }
}
            
