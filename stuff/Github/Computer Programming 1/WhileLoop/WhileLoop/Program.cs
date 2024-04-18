using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            
            
            //Exercise 1. Make a while loop that outputs 2,4,6,8,10
            int k = 0;
            while (k < 10)
            {
                k += 2;
                Console.WriteLine(k);
            }
            Console.ReadLine();
            
            int counter3 = 2;
            while(counter3 <= 200)
            {
                Console.WriteLine($"Counter 3 {counter3}");
                counter3 *= 2;
            }
            Console.ReadLine();
            

            while (true)
            {
                Console.WriteLine("This is an infinite loop");
                break;
            }

            bool loopRunning = true;
            while(loopRunning)
            {
                Console.WriteLine("");
            }
            Console.ReadLine();

            int x = 0;
            bool userInput = false;
            while (!userInput)
            {
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x >= 0 && x < 100)
                    {
                        userInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 0-99");
                    }
                }
                catch
                {
                    Console.WriteLine("Please input a valid int");

                }
            }
            Console.WriteLine(x);
            Console.ReadLine();
            */
            int attempts = 0;
            int hello = 0;
            while (attempts < 4)
            {
                Console.WriteLine($"Attempt: {attempts}");
                attempts++;
                try
                {
                    hello = Convert.ToInt32(Console.ReadLine());
                    if (hello >= 0 && hello < 100)
                    {
                        attempts = 4;
                    }
                    else
                    {
                        Console.WriteLine("Input a number between 0-99");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number");
                }
                if (attempts == 4)
                {
                    Console.WriteLine("You failed.");
                }
            }
            Console.ReadLine();
        }
    }
}
