using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Joshua Saetern
//Mid Term 
//CSI120
//2.8.2024

namespace MidTerm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task12();
            
            Console.ReadLine();
        }
        public static  void Task1()
        {
            int one = 33000;
            sbyte two = -10;
            decimal three = 12.99m;
            double four = 0.123456789987;
            float five = 1.23f;
            long six = -6000000000;
        }
        public static void Task2()
        {
            float num1 = -1f;
            float num2 = 1f;
            //I decided to make an array so i can print them all easily
            bool[] myBools = new bool[6];
            myBools[0] = num1 != 0.5;
            myBools[1] = (num2 < 0.1) || (num2 > 0.9);
            myBools[2] = (num1 > -10) && (num1 < 10);
            myBools[3] = (num2 < -1) && (num2 > 1);
            myBools[4] = (num1 < num2) || (num2 > -5);
            myBools[5] = (num1 < 0.5) && (num1 > -0.5);
            //Print out contents of myBools
            for (int k = 0; k < myBools.Length; k++)
            { 
                Console.WriteLine($"{myBools[k]} \n");
            }
        }
        public static void Task3()
        {
            Console.WriteLine("Please enter your length, width, and height");
            double length = getUserDouble();
            double width = getUserDouble();
            double height = getUserDouble();
            //Calculate and return area
            Console.WriteLine($"{length} * {width} * {height} = {length * width * height}");
        }
        public static void Task4()
        {
            Console.WriteLine("Input an integer to see if it is divisible by 5 or 9");
            int num1 = getUserInt();
            //Check for both
            if ((num1 % 9 == 0) && (num1 % 5 == 0))
            {
                Console.WriteLine($"{num1} is divisible by both 5 and 9!");
            }
            //Check for if neither 9 or 5 is divisible
            else if ((num1 % 9 != 0) && (num1 % 5 != 0))
            {
                Console.WriteLine($"{num1} is not divisble by 5 or 9!");
            }
            //Check for 9
            else if (num1 % 9 == 0)
            {
                Console.WriteLine($"{num1} is divisible by only 9!");
            }
            else
            //Must be divisible by 5
            {
                Console.WriteLine($"{num1} is divisble by only 5!");
            }
        }
        public static void Task5()
        {
            //Get user inputs to calculate our total price
            Console.WriteLine("Input the weight in pounds");
            double pounds = getUserDouble();
            Console.WriteLine("Input the price per pound");
            double price = getUserDouble();
            //Total price
            double totalPrice = pounds * price;
            double discount = 0;
            if (totalPrice > 500)
            {
                discount = 20;
            }
            else if (totalPrice > 200)
            {
                discount = 10;
            }
            else if (totalPrice > 100)
            {
                discount = 5;
            }
            Console.WriteLine($"Your original price was: ${totalPrice:F2} your discount is {discount}% so your total is ${(totalPrice - totalPrice * (discount / 100)):F2} ");
        }
        public static void Task6()
        {
            Console.WriteLine("Please input 3 integers");
            int num1 = getUserInt();
            int num2 = getUserInt();
            int num3 = getUserInt();
            //Check for num2
            if ((num1 < num2) && (num2 < num3) || (num3 < num2) && (num2 < num1)) 
            {
                Console.WriteLine($"{num2} is the middle number");
            }
            //Check for num1
            else if ((num2 < num1) && (num1 < num3) || (num3 < num1) && (num1 < num2))
            {
                Console.WriteLine($"{num1} is the middle number");
            } 
            else
            {
                Console.WriteLine($"{num3} is the middle number");
            }
        }
        public static void Task7()
        {
            Console.WriteLine("Please input three integer values");
            int num1 = getUserInt();
            int num2 = getUserInt();
            int num3 = getUserInt();
            //Check if num1 is smallest
            if (num1 < num2 && num1 < num3)
            {
                num1 = 0;
            }
            //Check if num2 is the smallest
            else if (num2 < num1 && num2 < num3)
            {
                num2 = 0;
            }
            //Runs if num 3 is the smallest
            else
            {
                num3 = 0;
            }
            //This works because the smallest number has been reduced to 0
            Console.WriteLine($"The average of your 2 highest numbers are {(num1+num2+num3)/2}");
        }
        public static void Task8()
        {
            Console.WriteLine("Please input your x coordinate");
            int x = getUserInt();
            Console.WriteLine("Please input your y coordinate");
            int y = getUserInt();
            // (+,+)
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Quadrant I");
            }
            // (+,-)
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Quadrant IV");
            }
            // (-,-)
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Quadrant III");
            }
            // (-,+)
            else
            {
                Console.WriteLine("Quadrant II");
            }
        }
        public static void Task9()
        {
            Console.WriteLine("Please input the month of the year 1-12");
            int month = getUserInt();
            switch (month)
            {
                case 1:
                    Console.WriteLine("Its January!");
                    break;
                case 2:
                    Console.WriteLine("Its February");
                    break;
                case 3:
                    Console.WriteLine("Its March!");
                    break;
                case 4:
                    Console.WriteLine("Its April");
                    break;
                case 5:
                    Console.WriteLine("Its May!");
                    break;
                case 6:
                    Console.WriteLine("Its June!");
                    break;
                case 7:
                    Console.WriteLine("Its July!");
                    break;
                case 8:
                    Console.WriteLine("Its August!");
                    break;
                case 9:
                    Console.WriteLine("Its September!");
                    break;
                case 10:
                    Console.WriteLine("Its October!");
                    break;
                case 11:
                    Console.WriteLine("Its November!");
                    break;
                case 12:
                    Console.WriteLine("Its December!");
                    break;
                default:
                    Console.WriteLine("Error: Invalid Month of the Year");
                    break;
            }
        }
        public static void Task10()
        {
            int k = 3;
            while (k < 100)
            {
                Console.WriteLine(k);
                k *= 3;
            }
        }
        public static void Task11()
        {
            Console.WriteLine("Please choose a password");
            String secretPassword = Console.ReadLine();
            //Start the confirmation
            int attempts = 4;
            //The first attempt doesnt count as an attempt (i presume) so attempts start as 4
            while (attempts > 0)
            {
                Console.WriteLine("Please input your password:");
                String guess = Console.ReadLine();
                attempts--;
                if (guess.Equals(secretPassword))
                {
                    Console.WriteLine("User logged in");
                    break;
                }
                else
                {
                    Console.WriteLine($"Login failed. \n You have {attempts} attempts remaining");
                }
            }
        }
        public static void Task12()
        {
            Random rand = new Random();
            int lotteryNumber = rand.Next(1, 292000001);
            int guess = -1;
            int trys = 0;
            while (guess != lotteryNumber)
            {
                trys++;
                guess = rand.Next(1, 292000001);
            }
            Console.WriteLine($"You won the lottery! It look you only {trys:N0} trys!");
        }

        //Methods for getting user input
        public static int getUserInt()
        {
            int num = -1;
            while (true)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("please enter an integer");
                }
            }
            return num;

        }
        public static double getUserDouble()
        {
            double num = -1;
            while (true)
            {
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("please enter a double");
                }
            }
            return num;
        }
    }
}
