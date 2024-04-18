using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

//Joshua Saetern
//02.20.2024
//CSI 120
//Lab Seven

namespace LabSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Sample array for testing
            int[] myArray = { 10, 5, 7 };
            
            //Task 1
            int[] myArray2 = Task1(10);
            foreach (int k in myArray2)
            {
                Console.WriteLine(k);
            }
            
            //Task 2 
            Task2(myArray);

            //Task 3
            Console.WriteLine(Task3("Hello", 'e')); 
            
            //Task 4
            Console.WriteLine(Task4(myArray));

            //Task 5
            double[] myArray3 = { 1, 2, 3 };
            double[] myNewArray3 = Task5(myArray3, 2.5, 2);
            foreach (double k in myNewArray3)
            {
                Console.WriteLine(k);
            }

            //Task 6
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"[i:{i},j:{j}] ");
                }
                Console.WriteLine();
            }

            //Task 7
            Task7();
            
            //Task 8
            Task8();
            

            //Extra Credit
            int spaces = 3;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(j > spaces)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
                spaces--;
            }
            /*
             * Trying to understand how to structure this
                    *
                   * *
                  * * *
                 * * * *
                * * * * *
               
            */

            //Keep terminal open
            Console.ReadLine();
        }
        //Task 1
        public static int[] Task1(int size)
        {
            Random rnd = new Random();
            int[] result = new int[size];
            for (int k = 0; k < size; k++)
            {
                result[k] = rnd.Next(100);
            }

            return result;
        }
        //Task 2 
        public static void Task2(int[] myArray)
        {
            for(int k = 0; k < myArray.Length; k++)
            {
                Console.WriteLine($"{myArray[k]} at index {k}");
            }
        }
        //Task 3
        public static int Task3(string value, char searchValue)
        {
            int ourIndex = -1;
            for (int k = 0; k < value.Length; k++)
            {
                //Doesnt account for multiple occurences of searchValue
                if (searchValue == value[k])
                {
                    ourIndex = k;
                }
            }
            return ourIndex;
        }
        //Task 4
        public static double Task4(int[] myArray)
        {
            double total = 0;
            for (int k = 0; k < myArray.Length; k++)
            {
                total += myArray[k];
            }
            return total / myArray.Length;
        }
        //Task 5 
        public static double[] Task5(double[] myArray, double value, int index)
        {
            //Create new array
            double[] result = new double[myArray.Length + 1];
            try
            { 
                for (int i = 0, i2 = 0; i < myArray.Length; i++, i2++)
                {
                    //Checks if value was inserted
                    if (i != i2)
                    {
                        result[i2] = myArray[i];  
                    }
                    else if (myArray[i] < value)
                    {
                        result[i2] = myArray[i];
                    }
                    else
                    {
                        result[i2] = value;
                        i--;
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
        public static void Task7()
        {
            int rows;
            int cols;
            Console.WriteLine("Please input your number of rows");
            while (!int.TryParse(Console.ReadLine(), out rows))
            {
                Console.WriteLine("Please input a valid int");
            }
            Console.WriteLine("Please input your number of columns");
            while (!int.TryParse(Console.ReadLine(), out cols))
            {
                Console.WriteLine("Please input a valid int");
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine() ;
            }
        }
        public static void Task8()
        {
            int rows;
            Console.WriteLine("Please input your number of rows");
            while (!int.TryParse(Console.ReadLine(), out rows))
            {
                Console.WriteLine("Please input a valid int");
            }
            for (int i = 0; rows > 0; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                rows--;
            }
        }
    }
}
