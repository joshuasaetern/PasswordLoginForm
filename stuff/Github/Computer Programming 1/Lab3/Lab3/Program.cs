using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Print1();

            // Task 2
            // Ask for input and attempt to convert to int
            Console.WriteLine("Please input a int number");
            String input1 = Console.ReadLine();
            try {
                int inputInt = Convert.ToInt32(input1);
                Console.WriteLine($"Conversion success! {inputInt.GetType()}");
            }
            catch (Exception ex)
            {
                // Executes the if conversion is failed and the reason
                Console.WriteLine("Conversion failed.\n" + ex.Message);
            }
            // Ask for input and attempt to convert to double
            Console.WriteLine("Please input a double number");
            String input2 = Console.ReadLine();
            try
            {
                double inputDouble = Convert.ToDouble(input2);
                Console.WriteLine($"Conversion success! {inputDouble.GetType()}\n");
            }
            catch (Exception ex)
            {
                // Executes the if conversion is failed and the reason
                Console.WriteLine("Conversion failed.\n" + ex.Message);
            }
            // Ask for input and attempt to convert to float
            Console.WriteLine("Please input a float/single number");
            String input3 = Console.ReadLine();
            try
            {
                float inputSingle = Convert.ToSingle(input3);
                Console.WriteLine($"Conversion success! {inputSingle.GetType()}\n");
            }
            catch (Exception ex)
            {
                // Executes the if conversion is failed and the reason
                Console.WriteLine("Conversion failed.\n" + ex.Message);
            }

            // Task 3
            // Prompt user to input prices
            Console.WriteLine("Please input the regular price");
            String regularPrice = Console.ReadLine();
            Console.WriteLine("Please input the sale price");
            String salePrice = Console.ReadLine();
            Console.WriteLine($"The regular price is {regularPrice} and the sale price is {salePrice} \n");
            // Attempt to convert strings to doubles
            try
            {
                double regularNum = Convert.ToDouble(regularPrice);
                double saleNum = Convert.ToDouble(salePrice);
                //Return the prices saved and percentage
                Console.WriteLine($"You saved: ${regularNum - saleNum} you payed {saleNum / regularNum * 100}% of the original price.\n");
            }
            // Run if exception error
            catch (Exception ex)
            {
                Console.WriteLine("Conversion failed " + ex.Message + "\n");
            }

            // Task 4
            //
            Console.WriteLine("Input a temperature in Celcius and it will be converted to Fahrenheit");
            String temperatureString = Console.ReadLine();
            try
            {
                // Conversion to F
                double temperatureC = Convert.ToDouble(temperatureString);
                double temperatureF = temperatureC * 9 / 5 + 32;
                Console.WriteLine($"Celcius: {temperatureC} Fahrenheit: {temperatureF}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Error {ex.Message}");
            }

            // Task 5

            Console.WriteLine("Input an amount of change in pennies between 0-99");
            try
            {
                int change = Convert.ToInt32(Console.ReadLine());
                // Make sure that our input is in the required range
                if (change < 100 && change > -1)
                {
                    // Making a variable i can subtract from without messing up original variable.
                    int currentChange = change;
                    int quarters = currentChange / 25;
                    currentChange = currentChange - quarters * 25;
                    int dimes = currentChange / 10;
                    currentChange = currentChange - dimes * 10;
                    int nickles = currentChange / 5;
                    currentChange = currentChange - nickles * 5;
                    int pennies = currentChange;
                    Console.WriteLine($"{change} can be divided into Quarters: {quarters} Dimes: {dimes} Nickles: {nickles} Pennies: {pennies}\n");
                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
            }
            catch
            {
                Console.WriteLine("Conversion Failed");
            }

            // Task 6

            Console.WriteLine("Please input a temperature in Celcius");
            try
            {
                double temperatureC2 = Convert.ToDouble(Console.ReadLine());
                // Check to see if it is freezing...
                if (temperatureC2 > 0)
                {
                    Console.WriteLine("Its not freezing\n");
                }
                else
                {
                    Console.WriteLine("Its freezing!!!\n");
                }
            }
            catch
            {
                Console.WriteLine("Conversion failed.");
            }

            // Task 7 

            // Im not sure if decimal numbers can be considered even or odd
            Console.WriteLine("Please input a whole number");
            try
            {
                int userNum = Convert.ToInt32(Console.ReadLine());
                // Checking to see if number is even or odd
                if ((userNum / 2) == 0)
                {
                    Console.WriteLine($"{userNum} is even!");
                }
                else
                {
                    Console.WriteLine($"{userNum} is odd!");
                }

            }
            catch
            {
                Console.WriteLine("Conversion error!!!");
            }

            //Keeps our terminal open
            Console.ReadLine();

        }

        //Methods
        public static void Print1() //Prints Start of Lab 3
        {
            Console.WriteLine("Start of Lab 3");
        }
    }
}
