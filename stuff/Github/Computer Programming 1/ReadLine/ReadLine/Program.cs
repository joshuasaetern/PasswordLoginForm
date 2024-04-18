using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //To get input from the user First we Prompt
            Console.WriteLine("Please enter your name");
            //Use Console.ReadLine() and store it into a variable. (Console.ReadLine() will always return a String)
            String name = Console.ReadLine();
            Console.WriteLine("Your name is: " + name);
            //Return the string name
            Console.WriteLine("Please enter your age");
            String ageString = Console.ReadLine();
            //Use a Parse to convert string to the age
            int age = int.Parse(ageString);
            //Calculate their age in 2029
            int ageIn2029 = age + 5;
            Console.WriteLine("In 2029 you will be: " + ageIn2029);
            */

            //As an exercise
            //Declare 3 doubles
            //Get values from the user and output the sum of the numbers

            Console.WriteLine("Please input number 1");
            double num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please input number 2");
            double num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please input number 3");
            double num3 = Double.Parse(Console.ReadLine());
            double sum = (num1 + num2 + num3);

            Console.WriteLine("The sum of your numbers is: " + );

            //Use a Console.ReadLine() to keep the terminal open
            Console.ReadLine();

        }
    }
}
            
