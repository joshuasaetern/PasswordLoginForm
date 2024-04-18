using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Joshua Saetern
//2-2-2024
//CSI 120
//Lab Five

namespace LabFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //consolewritelines are for spacing
            Task1();
            Console.WriteLine();
            Task2();
            Console.WriteLine();
            Task3();
            Console.WriteLine();
            Task4();
            Console.WriteLine();
            Task5();
            Console.WriteLine();
            Task6();
            Console.WriteLine();
            Task7();
            
            Console.ReadLine();
        }

        //wanted to try using a method for fun
        public static int getUserInt()
        {
            int num = 0;
            //Get user input
            while (true)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Please input an integer.");
                }
            }
            return num;
        }
        public static void Task1()
        {
            //print 1,2,3,4
            int num = 0;
            while (num < 5)
            {
                Console.WriteLine(num);
                num++;
            }
        }
        public static void Task2()
        {
            //print 1,3,5,7,9
            int num = 1;
            while (num < 10)
            {
                Console.WriteLine(num);
                num += 2;
            }
        }
        public static void Task3()
        {
            Console.WriteLine("Please input a positive int");
            int num = -1;
            while(true)
            {
                num = getUserInt();
                if (num > 0)
                {
                    break; 
                }
                else 
                {
                    Console.WriteLine("Please input a positive int");
                }

            }
            //Process for finding the sum
            int sum = 0;
            Console.WriteLine("The sum of: ");
            while (num > 0)
            {
                num--;
                sum += num;
                Console.Write($"{num} ");
            }
            Console.Write($"is: {sum}");
        }
        public static void Task4()
        {
            Console.WriteLine("Input the radius for your circle.");
            double num = 0;
            //Get user double
            while (true)
            {
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Please input a double.");
                }
            }
            //Print area of a circle
            Console.WriteLine($"Your area is {Math.PI * Math.Pow(num, 2)}");
        }
        public static void Task5()
        {
            Random rand = new Random();
            int num = -1;
            Console.WriteLine("Please input a number between 0-99");
            while (num < 0 || num > 99)
            {
                num = getUserInt();
            }
            //Print empty line
            Console.WriteLine();
            for (int k = 0; k < num; k++)
            {
                Console.WriteLine(rand.Next(0, 100));
            }
        }
        public static void Task6()
        {
            Random rand = new Random();
            //Generate a number between 0-99 for user to guess
            int num = rand.Next(0, 100);
            Console.WriteLine("Try to guess a number between 0-99!");
            while (true)
            {
                //Make the guess variable
                //Give hints and such
                int guess = getUserInt();
                if (guess == num)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else if (guess < num)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("Too high!");
                }
            }
        }
        public static void Task7()
        {
            Console.WriteLine("Enter a positive int between 1-12");
            int num = -1;
            while (true)
            {
                num = getUserInt();
                if (num > 0 && num < 13)
                {
                    break;
                }
                Console.WriteLine("Please enter a number between 1-12");
            }
            for (int k = 1; k < 13; k++)
            {
                Console.WriteLine($"{num} x {k} = {num*k}");
            }
        }
    }
}
