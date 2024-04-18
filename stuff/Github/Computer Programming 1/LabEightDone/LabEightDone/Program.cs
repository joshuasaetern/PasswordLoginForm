using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//Joshua Saetern
//CSI 120
//03.01.2024
//Lab Eight

namespace LabEightDone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            String[] products = Task1(); 
            //Print products
            foreach (String x in products)
            {
                Console.Write($"{x} ");
            }
            //Makes a new line for formatting purposes
            Console.WriteLine("\n");

            //Task 2
            double[] prices = Task2(products);
            foreach (double x in prices)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n");

            //Task 3
            SearchArray(products, prices);
            
            //Task 4
            MinMaxArray(products, prices);
            
            //Task 5
            int[] numbers = { 1, 7, 6, 2 };
            numbers = BubbleSort(numbers);
            foreach (int x in numbers)
            {
                Console.Write(x + " ");
            }
            //Task 6
            int[] array2 = { 5, 7, 10, 20 };
            int[] array3 = MergeArray(numbers, array2 );
            foreach (int x in array3)
            {
                Console.WriteLine(x + " ");
            }
            //Task 7
            Task7();
            
            //Task 8
            String[,] board = {{"X","*","O"},
                               {"*","X","O"},
                               {"*","*","X"}};

            Console.WriteLine(checkWin(board));
            String[,] board2 = {{"X","*","O"},
                                {"*","O","X"},
                                {"O","X","*"}};
             
            Console.WriteLine(checkWin(board2));

            String[,] board3 = {{"X","*","O"},
                                {"*","X","X"},
                                {"O","O","*"}};
            Console.WriteLine(checkWin(board3));            
            //Keep terminal open
            Console.ReadLine();
        }
        public static String[] Task1()
        {
            Console.WriteLine("How many products would you like to enter?");
            //Use this for the size of the array
            int products = Convert.ToInt32(GetUserNum());
            String[] result = new String[products];
            //Add each element to our array
            for (int k = 0; k < products; k++)
            {
                // +1 because if not it will say please enter product 0...
                Console.WriteLine($"Please enter product {k + 1}:");
                result[k] = Console.ReadLine();
            }
            return result;
        }
        public static double[] Task2(String[] products) 
        {
            double[] prices = new double[products.Length];
            //Loop through products and use each iteration to add our prices
            for(int k = 0; k < products.Length; k++)
            {
                Console.WriteLine($"Please enter the price for {products[k]}");
                prices[k] = GetUserNum();
            }
            return prices;
        }
        //Task 3
        public static void SearchArray(String[] products, double[] prices)
        {
            //Loop runs until user exits manually
            while(true)
            {
                int index = 0;
                Console.WriteLine("Input product name");
                Console.WriteLine("Type exit when finished \n");
                //Make all comparisons lowercase
                String userSearch = Console.ReadLine().ToLower();
                if (userSearch.ToLower() == "exit")
                {
                    break;
                }
                if (products.Contains(userSearch))
                {
                    index = Array.IndexOf(products, userSearch);
                    Console.WriteLine($"{products[index]}, Price: {prices[index]:C} \n");
                }
                else
                {
                    Console.WriteLine("Product does not exist \n");
                }
            }
        }
        //Task 4
        public static void MinMaxArray(String[] products, double[] prices)
        {
            double min = 0;
            double max = 0;
            while (true)
            {
                Console.WriteLine("Please input your minimum price");
                min = GetUserNum();
                Console.WriteLine("Please input your maximum price");
                max = GetUserNum();
                //Checks for validity of numbers
                if (min > max || min == 0 || max == 0)
                {
                    Console.WriteLine("Please input valid numbers");
                }
                //Exit loop if numbers are good
                else
                {
                    break;
                }
            }
            for (int k = 0; k < products.Length; k++)
            {
                //Check if product fits in price range
                if (prices[k] > min && prices[k] < max)
                {
                    Console.WriteLine($"{products[k]}: {prices[k]}");
                }
            }
            
        }
        //Task 5 
        public static int[] BubbleSort(int[] array)
        {
            int n = array.Length; 
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
            return array;
        }
        //Task 6 
        public static int[] MergeArray(int[] array1, int[] array2)
        {
            //Make an array with the right size
            int[] array3 = new int[array1.Length + array2.Length];
            //Add all elements into the new array
            for (int k = 0; k < array1.Length; k++)
            {
                array3[k] = array1[k];
            }
            for (int k = 0; k < array2.Length; k++)
            {
                array3[k] = array2[k];
            }
            return BubbleSort(array3);
        }
        //Task 7
        public static void Task7()
        {
            //Create array
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //Loop through array
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i , j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static String checkWin(String[,] board)
        {
            int xCount = 0;
            int oCount = 0;
            //Check Validitiy
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == "X")
                    {
                        xCount++;
                    }
                    if (board[i, j] == "O")
                    {
                        oCount++;
                    }
                }
            }
            //Checks if a player went more than once
            if (xCount - oCount > 1 || xCount - oCount < -1)
            {
                return "Invalid Board";
            }
            //Check win conditions for X
            //Horizontal
            if (board[0, 0] == "X" && board[0, 1] == "X" && board[0, 2] == "X") { return "X is the Winner"; }
            if (board[1, 0] == "X" && board[1, 1] == "X" && board[1, 2] == "X") { return "X is the Winner"; }
            if (board[2, 0] == "X" && board[2, 1] == "X" && board[2, 2] == "X") { return "X is the Winner"; }
            //Vertical
            if (board[0, 0] == "X" && board[0, 1] == "X" && board[0, 2] == "X") { return "X is the Winner"; }
            if (board[1, 0] == "X" && board[1, 1] == "X" && board[1, 2] == "X") { return "X is the Winner"; }
            if (board[2, 0] == "X" && board[2, 1] == "X" && board[2, 2] == "X") { return "X is the Winner"; }
            //Diagonal
            if (board[0, 0] == "X" && board[1, 1] == "X" && board[2, 2] == "X") { return "X is the Winner"; }
            if (board[0, 2] == "X" && board[1, 1] == "X" && board[2, 0] == "X") { return "X is the Winner"; }

            //Check win conditions for O
            if (board[0, 0] == "O" && board[0, 1] == "O" && board[0, 2] == "O") { return "O is the Winner"; }
            if (board[1, 0] == "O" && board[1, 1] == "O" && board[1, 2] == "O") { return "O is the Winner"; }
            if (board[2, 0] == "O" && board[2, 1] == "O" && board[2, 2] == "O") { return "O is the Winner"; }
            //Vertical
            if (board[0, 0] == "O" && board[0, 1] == "O" && board[0, 2] == "O") { return "O is the Winner"; }
            if (board[1, 0] == "O" && board[1, 1] == "O" && board[1, 2] == "O") { return "O is the Winner"; }
            if (board[2, 0] == "O" && board[2, 1] == "O" && board[2, 2] == "O") { return "O is the Winner"; }
            //Diagonal
            if (board[0, 0] == "O" && board[1, 1] == "O" && board[2, 2] == "O") { return "O is the Winner"; }
            if (board[0, 2] == "O" && board[1, 1] == "O" && board[2, 0] == "O") { return "O is the Winner"; }
            //If code makes it here then nothing was returned to this point
            return "No winner";

            /* Visualization of board
             * [0,0] [0,1] [0,2]
             * [1,0] [1,1] [1,2]
             * [2,0] [2,1] [2,2]
            */

        }
        public static double GetUserNum()
        {
            //Cast to an int if needed. But do note that it will round up
            double num;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Please input a valid number");
            }
            return num;
        }
    }
}
