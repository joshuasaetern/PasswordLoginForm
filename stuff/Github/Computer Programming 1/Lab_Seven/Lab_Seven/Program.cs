using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Joshua Saetern
//CSI 120
//Lab Six
//2.15.2024

namespace Lab_Seven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Task1("Start Lab 6");
            //Task2
            Console.WriteLine(Task2(1, 2, 3));
            //Task3
            Task3(1, 2, 3);
            //Task4 
            int userNum;
            Console.WriteLine("Input a integer for Task 4");
            while (!int.TryParse(Console.ReadLine(), out userNum)) 
            {
                Console.WriteLine("Please input a integer");
            }
            Task4(userNum);
            //Task5
            decimal userNum2;
            decimal userNum3;
            decimal userNum4;
            Console.WriteLine("Please input your first decimal");
            while (!decimal.TryParse(Console.ReadLine(),out userNum2))
            {
                Console.WriteLine("Please input a decimal");
            }
            Console.WriteLine("Please input your second decimal");
            while (!decimal.TryParse(Console.ReadLine(), out userNum3))
            {
                Console.WriteLine("Please input a decimal");
            }
            Console.WriteLine("Please input your third decimal");
            while (!decimal.TryParse(Console.ReadLine(), out userNum4))
            {
                Console.WriteLine("Please input a decimal");
            }
            Console.WriteLine(Task5(userNum2, userNum3, userNum4));
            //Task6
            int userNum5;
            int userNum6;
            Console.WriteLine("Please input your first number");
            while (!int.TryParse(Console.ReadLine(), out userNum5))
            {
                Console.WriteLine("Please input an integer");
            }
            Console.WriteLine("Please input your second number");
            while (!int.TryParse(Console.ReadLine(), out userNum6))
            {
                Console.WriteLine("Please input an integer");
            }
            Task6(userNum5, userNum6);
            
            //Task7
            Console.WriteLine(Task7(111));
            //Task8
            Console.WriteLine(Task8(500));
            //Keep console open
            Console.ReadLine();
        }
        public static void Task1(String userInput)
        {
            Console.WriteLine(userInput);
        }
        public static double Task2(double num1, double num2, double num3) 
        {
            return (num1 + num2 + num3) / 3;
        }
        public static void Task3(int num1, int num2, int num3) 
        {
            Console.WriteLine($"{num1} {num2} {num3}");
        }
        public static void Task4(int num)
        {
            for (int k = num-1; k > 0; k--)
            {
                //Checks if the number is even
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
            }
        }
        public static decimal Task5(decimal num1, decimal num2, decimal num3)
        {
            //num1 is the largest
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }  
            //num2 is the largest
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            //num3 is the largest
            else
            {
                return num3;
            }
        }
        public static void Task6(int num1, int num2)
        {
            //Num 1 is bigger so subtract
            if (num1 > num2)
            {
                for (int k = num1 -1; k > num2; k--)
                {
                    Console.WriteLine(k);
                }
            }
            //Num 2 is bigger so add
            else
            {
                for (int k = num1 + 1; k < num2; k++)
                {
                    Console.WriteLine(k);
                }
            }
        }
        public static int Task7(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            return sum;
        }

        public static bool Task8(int num)
        {
            if (num == 2)
            {
                return true;
            }
            if(num % 2 == 0)
            {
                return false;
            }

            for (int k = 3; k < Math.Sqrt(num); k+=2)
            {
                if (num % k == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
