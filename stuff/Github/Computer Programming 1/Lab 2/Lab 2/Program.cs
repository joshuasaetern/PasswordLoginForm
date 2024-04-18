using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Joshua Saetern
//1.11/2024
//Computer Progamming 1
//Lab 2: Variables, Input and Output

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Prompt user for name and address
            Console.WriteLine("Please input your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " please input your address: ");
            String address = Console.ReadLine();
            //Return name and address
            Console.WriteLine("Hello " + name + " your address is: " + address + "\n");

            //Task 2
            //Have user input numbers in succession
            Console.WriteLine("Please input three consecutive integer numbers: ");
            double num1 = Double.Parse(Console.ReadLine());
            double num2 = Double.Parse(Console.ReadLine());
            double num3 = Double.Parse(Console.ReadLine());
            //Calculate average
            double average = (num1 + num2 + num3) / 3;
            Console.WriteLine("The average of your numbers is: " + average + "\n");

            //Task 3
            //Prompt user and create variables
            Console.WriteLine("Please input a base for your triangle: ");
            double triangleBase = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please input a height for your triangle: ");
            double triangleHeight = Double.Parse(Console.ReadLine());
            //Calculate and return area
            double triangleArea = triangleBase * triangleHeight * 0.5;
            Console.WriteLine("The area for your triangle is: " + triangleArea + "\n");

            //Task 4 
            //Get random item and price
            Console.WriteLine("Input the price of paper towels: ");
            decimal price = decimal.Parse(Console.ReadLine());
            //Return the item price and the requested quantity
            Console.WriteLine("The price of paper towels is: " + price + "\n" + "How many paper towels do you want to buy?");
            decimal totalPrice = decimal.Parse(Console.ReadLine())*price;
            Console.WriteLine("Your total price is: " + totalPrice + "\n");

            //Task 5
            //Prompt the user to input two numbers and return sum, difference, product, and quotient
            Console.WriteLine("Please input number 1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input number 2");
            int number2 = int.Parse(Console.ReadLine());
            //Doing all the math here
            int sum = number1 + number2; int difference = number1 - number2;
            int product = number1 * number2; double quotient = number1 / number2;
            //Returning everything
            Console.WriteLine("Your sum is: " + sum + " Your difference is: " + difference + " Your product is: " + product + " Your quotient is: " + quotient + "\n");

            //Task 6
            //Print all required text
            Console.WriteLine("Welcome to the ATM!");
            Console.WriteLine("Please select an option from the menu below: ");
            //Make an array so that i can return a specfic option
            String[] options = { "1. Check Balance", "2. Withdraw Cash", "3. Deposit Cash", "4. Transfer Funds", "5. Change Pin", "6. Exit" };
            for(int k = 0; k<options.Length; k++)
            {
                Console.WriteLine(options[k]);
            }
            Console.WriteLine("Enter your choice ");
            int choice = int.Parse(Console.ReadLine())-1;
            Console.WriteLine("You chose: " + options[choice]);

            //Task 7

            short n1 = 500;
            long n2 = 123456789123456789;
            double n3 = 3.123456789;
            float n4 = 3.2f;
            decimal n5 = 14.37m;
            Console.WriteLine(n3);

            //Task 8
            /* 
               A parse is when you take a data type and translate it to a different
               data type. 

               The reason you would use a parse is if you need to change a string 
               to a number type so that you can use math.

            */

            //Keep terminal open
            Console.ReadLine();
        }
    }
}
