using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TryParseNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            string intString = Console.ReadLine();
            //TryParse() returns a boolean
            //When the parse fails the number value is default zero
            bool success = int.TryParse(intString, out int number);
            Console.WriteLine(success.ToString());
            Console.ReadLine();
            
            Console.WriteLine("Try parse with a loop");
            Console.WriteLine("Please enter a whole number");
            String input = Console.ReadLine();
            int num2;
            bool success2 = int.TryParse(input, out num2); 
            while (!success2)
            {
                Console.WriteLine("Please input a whole number");
                input = Console.ReadLine();
                success2 = int.TryParse(input, out num2);
            }
            Console.WriteLine("Success!");
            Console.ReadLine();
            

            int num3;
            while(!int.TryParse(Console.ReadLine(),out num3)) {
                Console.WriteLine("Please input a whole number");
            }
            Console.WriteLine($"Num is: {num3}");
            Console.ReadLine();
            

            for (int k = 3; k < 19; k+=3) 
            {
                Console.WriteLine(k);
            }

            for (int i = 5, j = 20; i < j; i++, j--)
            {
                Console.WriteLine($"i is {i} and j is {j}");
            }
            
            */
            int counter = 0;
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    Console.Write("*");
                    counter++;
                }
                Console.WriteLine();
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
