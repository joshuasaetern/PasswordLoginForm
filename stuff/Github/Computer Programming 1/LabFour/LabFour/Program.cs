using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Joshua Saetern
//CSI120 
//Lab four
//01.23.2024

namespace LabFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I made this a loop so i can test everything without having to open terminal everytime
            //Loops ends when you enter 9
            bool game = true;
            while (game)
            {
                Console.WriteLine("----Lab Four----");
                Console.WriteLine("Please select a lab problem");
                Console.WriteLine("Press 2 for problem 2");
                Console.WriteLine("Press 3 for problem 3");
                Console.WriteLine("Press 4 for problem 4");
                Console.WriteLine("Press 5 for problem 5");
                Console.WriteLine("Press 6 for problem 6");
                Console.WriteLine("Press 7 for problem 7");
                Console.WriteLine("Press 8 for problem 8");
                Console.WriteLine("Press 9 to exit the program.");
                int userChoice = 0;
                try
                {
                    userChoice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Conversion failed.");
                }
                switch (userChoice)
                {
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
                        break;
                    case 8:
                        Task8();
                        break;
                    case 9:
                        game = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter 2-9");
                        break;
                }
                //Erases terminal to look nicer
                Console.WriteLine("\nPress enter to continue");
                Console.ReadLine();
                Console.Clear();
            }
        }
    public static void Task1()
    {
        
        }
        public static void Task2()
        {
            //Get inputs from the user
            Console.WriteLine("Input integer 1");
            String userStr1 = Console.ReadLine();
            Console.WriteLine("Input integer 2");
            String userStr2 = Console.ReadLine();
            //Try conversion and check even and odd
            try
            {
                int userInt1 = Convert.ToInt32(userStr1);
                int userInt2 = Convert.ToInt32(userStr2);

                if ((userInt1 % 2 == 0) && (userInt2 % 2 == 0))
                {
                    Console.WriteLine("Both Even");
                }
                else if ((userInt1 % 2 == 1) && (userInt2 % 2 == 1))
                {
                    Console.WriteLine("Both Odd");
                }
                else
                {
                    Console.WriteLine("One odd and One even");
                }
            }
            //Exception error
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public static void Task3()
        {
            //create balance variable and prompt user to withdrawl
            decimal balance = 500;
            Console.WriteLine($"Your balance is: {balance} how much would you like to withdrawl?");
            try
            {
                decimal userWithdrawl = Convert.ToDecimal(Console.ReadLine());
                if (balance < userWithdrawl)
                {
                    Console.WriteLine("There is not enough money to cover the withdrawl");
                }
                else
                {
                    Console.WriteLine($"Withdrawl successful, your new balance is ${balance - userWithdrawl}");
                }
            }
            catch
            {
                Console.WriteLine("Conversion failed");
            }
        }
        public static void Task4()
        {
            //Prompt user and use modulo to test if the int can be divisible by 2 and 5
            Console.WriteLine("Please input an integer");
            try
            {
                int userInt = Convert.ToInt32(Console.ReadLine());
                if ((userInt % 2 == 0) && (userInt % 5 == 0))
                {
                    Console.WriteLine("Divisible by 2 and 5");
                }
                else if (userInt % 2 == 0)
                {
                    Console.WriteLine("Divisible by 2 only"); 
                }
                else
                {
                    Console.WriteLine("Divisible by 5 only");
                }
            }
            catch
            {
                Console.WriteLine("Conversion failed");
            }

        }
        public static void Task5()
        {
            Console.WriteLine("Please input two integers");
            int num1 = 0;
            int num2 = 0;
            try
            {
                Console.WriteLine("Input integer 1:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input integer 2:");
                num2 = Convert.ToInt32(Console.ReadLine());

                //Check if both numbers are positive
                if (num1 > -1 && num2 > -1)
                {
                    Console.WriteLine($"{num1} and {num2} are in Quadrant I");
                }
                //Check if num 1 is negative and num 2 is positive
                else if (num1 < 0 && num2 > -1)
                {
                    Console.WriteLine($"{num1} and {num2} are in Quadrant II");
                }
                //Check if both are negative
                else if (num1 < 0 && num2 < 0)
                {
                    Console.WriteLine($"{num1} and {num2} are in Quadrant III");
                }
                //Last case is if num 1 is positive and num 2 is negative
                else
                {
                    Console.WriteLine($"{num1} and {num2} are in Quadrant IIII");
                }
            }
            catch
            {
                Console.WriteLine("Conversion failed.");
            }
        }
        public static void Task6()
        {
            //get test scores
            Console.WriteLine("Enter your Math test score 0-100");
            String mathStr = Console.ReadLine();
            Console.WriteLine("Enter your Science test score 0-100");
            String scienceStr = Console.ReadLine();
            Console.WriteLine("Enter your Language test score 0-100");
            String languageStr = Console.ReadLine();
            //convert to ints
            try
            {
                double mathScore = Convert.ToDouble(mathStr);
                double scienceScore = Convert.ToDouble(scienceStr);
                double langScore = Convert.ToDouble(languageStr);
                double average = (mathScore + scienceScore + langScore) / 3;
                //check for scholarship status 
                if ((average > 84) || (langScore > 89 && scienceScore > 89) || (mathScore > 96 || langScore > 96))
                {
                    Console.WriteLine("You have earned a scholarship!");
                }
                else
                {
                    Console.WriteLine("You have not earned a scholarship.");
                }
            }
            catch
            {
                Console.WriteLine("Conversion failed");
            }
        }
        public static void Task7()
        {
            //get 3 numbers
            Console.WriteLine("Input number 1");
            String numStr1 = Console.ReadLine();
            Console.WriteLine("Input number 2");
            String numStr2 = Console.ReadLine();
            Console.WriteLine("Input number 3");
            String numStr3 = Console.ReadLine();
            try
            {
                //convert numbers
                int num1 = Convert.ToInt32(numStr1);
                int num2 = Convert.ToInt32(numStr2);
                int num3 = Convert.ToInt32(numStr3);
                // check is num1 is is smaller than the other two
                if (num1 < num2 && num1 < num3)
                {
                    Console.WriteLine($"{num1} is the smallest number");
                }
                // check if num2 is smaller than the other two
                else if (num2 < num1 && num2 < num3)
                {
                    Console.WriteLine($"{num2} is the smallest number");
                }
                else
                {
                    Console.WriteLine($"{num3} is the smallest number");
                }
            }
            catch
            {
                Console.WriteLine("Conversion failed.");
            }
        }
        public static void Task8()
        {
            Console.WriteLine("Enter your total amount of purchases");
            String totalStr = Console.ReadLine();
            try
            {
                // check shipping
                double total = Convert.ToDouble(totalStr);
                if (total > 5000)
                {
                    Console.WriteLine("Shipping charges are $22.00");
                }
                else if (total > 1000.01)
                {
                    Console.WriteLine("Shipping charges are $20.00");
                }
                else if (total > 500.01)
                {
                    Console.WriteLine("Shipping charges are $18.00");
                }
                else if (total > 250.01)
                {
                    Console.WriteLine("Shipping charges are $15.00");
                }
                else
                {
                    Console.WriteLine("Shipping charges are $10.00");
                }
            }
            catch
            {
                Console.WriteLine("Conversion failed");
            }
        }
    }
}
