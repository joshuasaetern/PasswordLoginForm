using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Joshua Saetern
//CSI 120
//03.14.2024
//Tic Tac Toe
namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPlaying;
            Console.WriteLine("Welcome to Tic Tac Toe");
            Console.WriteLine("Would you like to play? 'y for yes'");
            String userInput = Console.ReadLine().ToLower();
            if (userInput == "y")
            {
                isPlaying = true;
            }
            else
            {
                isPlaying = false;
            }
            while (isPlaying)
            {
                Console.Clear();
                String[,] board = GenerateBoard();
                PrintBoard(board);
                //Player 1 = X , Player 2 = O
                while (!checkWinBool(board))
                {
                    //Goes through player 1s turn
                    String currentTurn = "Player1";
                    Console.WriteLine("Player 1 make your move");
                    PlayerTurn(board, currentTurn);
                    //Cleard board for readability
                    Console.Clear();
                    PrintBoard(board);
                    if (checkWinBool(board))
                    {
                        break;
                    }
                    currentTurn = "Player2";
                    Console.WriteLine("Player 2 make your move");
                    PlayerTurn(board, currentTurn);
                    Console.Clear();
                    PrintBoard(board);
                }
                //If code makes it here then the game has concluded
                Console.WriteLine(checkWin(board));
                Console.WriteLine("Would you like to play again? 'y for yes'");
                userInput = Console.ReadLine().ToLower();
                if (userInput == "y")
                {
                    isPlaying = true;
                }
                else
                {
                    isPlaying = false;
                }
            }
            Console.Clear();
            Console.WriteLine("Goodbye");

            //keeps terminal open
            Console.ReadLine();
        }
        //returns a 2d array which resembles an empty tic tac toe board
        public static String[,] GenerateBoard()
        {
            String[,] board = { {"1", "|", "2", "|", "3"},
                                {"-", "-", "-", "-", "-"},
                                {"4", "|", "5", "|", "6"},
                                {"-", "-", "-", "-", "-"},
                                {"7", "|", "8", "|", "9"} };
            /*[0,0] [0,1] [0,2] [0,3] [0,4]
             *[1,0] [1,1] [1,2] [1,3] [1,4]
             *[2,0] [2,1] [2,2] [2,3] [2,4] 
             *[3,0] [3,1] [3,2] [3,3] [3,4] 
             *[4,0] [4,1] [4,2] [4,3] [4,4]*/

            return board;
        }
        //This method will print our board
        public static void PrintBoard(String[,] board)
        {
            for (int j = 0; j < board.GetLength(0); j++)
            {
                for (int k = 0; k < board.GetLength(1); k++)
                {
                    Console.Write(board[j, k] + " ");
                }
                Console.WriteLine();
            }
        }
        public static String[,] PlayerTurn(String[,] board, String playersTurn)
        {
            //This decides if we will be using X or O
            String spot = "O";
            if (playersTurn == "Player1")
            {
                spot = "X";
            }
            //This variable will hold our spot on the board
            int userSpot;
            //checks if userSpot is 1-9 or not an int
            while (true)
            {
                int.TryParse(Console.ReadLine(), out userSpot);
                if (userSpot > 0 && userSpot < 10 && !isSpotTaken(board, userSpot))
                {
                    break;
                }
                else
                {
                    if (isSpotTaken(board, userSpot))
                    {
                        Console.WriteLine("Please choose an empty spot");
                    }
                    else
                    {
                        Console.WriteLine("Please input a number 1-9");
                    }
                }
            }
            //Determining where we change the board
            if (userSpot == 1) { board[0, 0] = spot; }
            else if (userSpot == 2) { board[0, 2] = spot; }
            else if (userSpot == 3) { board[0, 4] = spot; }
            else if (userSpot == 4) { board[2, 0] = spot; }
            else if (userSpot == 5) { board[2, 2] = spot; }
            else if (userSpot == 6) { board[2, 4] = spot; }
            else if (userSpot == 7) { board[4, 0] = spot; }
            else if (userSpot == 8) { board[4, 2] = spot; }
            else if (userSpot == 9) { board[4, 4] = spot; }
            return board;
        }
        //This is a modified version of my method from Lab Eight
        public static String checkWin(String[,] board)
        {
            //Check win conditions for X
            //Horizontal
            if (board[0, 0] == "X" && board[0, 2] == "X" && board[0, 4] == "X") { return "X is the Winner"; }
            else if (board[2, 0] == "X" && board[2, 2] == "X" && board[2, 4] == "X") { return "X is the Winner"; }
            else if (board[4, 0] == "X" && board[4, 2] == "X" && board[4, 4] == "X") { return "X is the Winner"; }
            //Vertical
            else if (board[0, 0] == "X" && board[2, 0] == "X" && board[4, 0] == "X") { return "X is the Winner"; }
            else if (board[0, 2] == "X" && board[2, 2] == "X" && board[4, 2] == "X") { return "X is the Winner"; }
            else if (board[0, 4] == "X" && board[2, 4] == "X" && board[4, 4] == "X") { return "X is the Winner"; }
            //Diagonal
            else if (board[0, 0] == "X" && board[2, 2] == "X" && board[4, 4] == "X") { return "X is the Winner"; }
            else if (board[0, 4] == "X" && board[2, 2] == "X" && board[4, 0] == "X") { return "X is the Winner"; }

            //Check win conditions for O
            //Horizontal
            else if (board[0, 0] == "O" && board[0, 2] == "O" && board[0, 4] == "O") { return "O is the Winner"; }
            else if (board[2, 0] == "O" && board[2, 2] == "O" && board[2, 4] == "O") { return "O is the Winner"; }
            else if (board[4, 0] == "O" && board[4, 2] == "O" && board[4, 4] == "O") { return "O is the Winner"; }
            //Vertical
            else if (board[0, 0] == "O" && board[2, 0] == "O" && board[4, 0] == "O") { return "O is the Winner"; }
            else if (board[0, 2] == "O" && board[2, 2] == "O" && board[4, 2] == "O") { return "O is the Winner"; }
            else if (board[0, 4] == "O" && board[2, 4] == "O" && board[4, 4] == "O") { return "O is the Winner"; }
            //Diagonal
            else if (board[0, 0] == "O" && board[2, 2] == "O" && board[4, 4] == "O") { return "O is the Winner"; }
            else if (board[0, 4] == "O" && board[2, 2] == "O" && board[4, 0] == "O") { return "O is the Winner"; }
            //If code makes it here then nothing was returned to this point
            return "No winner";
        }
        public static bool checkWinBool(String[,] board)
        {
            //Check win conditions for X
            //Horizontal
            if (board[0, 0] == "X" && board[0, 2] == "X" && board[0, 4] == "X") { return true; }
            else if (board[2, 0] == "X" && board[2, 2] == "X" && board[2, 4] == "X") { return true; }
            else if (board[4, 0] == "X" && board[4, 2] == "X" && board[4, 4] == "X") { return true; }
            //Vertical
            else if (board[0, 0] == "X" && board[2, 0] == "X" && board[4, 0] == "X") { return true; }
            else if (board[0, 2] == "X" && board[2, 2] == "X" && board[4, 2] == "X") { return true; }
            else if (board[0, 4] == "X" && board[2, 4] == "X" && board[4, 4] == "X") { return true; }
            //Diagonal
            else if (board[0, 0] == "X" && board[2, 2] == "X" && board[4, 4] == "X") { return true; }
            else if (board[0, 4] == "X" && board[2, 2] == "X" && board[4, 0] == "X") { return true; }

            //Check win conditions for O
            //Horizontal
            else if (board[0, 0] == "O" && board[0, 2] == "O" && board[0, 4] == "O") { return true; }
            else if (board[2, 0] == "O" && board[2, 2] == "O" && board[2, 4] == "O") { return true; }
            else if (board[4, 0] == "O" && board[4, 2] == "O" && board[4, 4] == "O") { return true; }
            //Vertical
            else if (board[0, 0] == "O" && board[2, 0] == "O" && board[4, 0] == "O") { return true; }
            else if (board[0, 2] == "O" && board[2, 2] == "O" && board[4, 2] == "O") { return true; }
            else if (board[0, 4] == "O" && board[2, 4] == "O" && board[4, 4] == "O") { return true; }
            //Diagonal
            else if (board[0, 0] == "O" && board[2, 2] == "O" && board[4, 4] == "O") { return true; }
            else if (board[0, 4] == "O" && board[2, 2] == "O" && board[4, 0] == "O") { return true; }
            //Checks if board is full
            int count = 0;
            for (int j = 0; j < board.GetLength(0); j++)
            {
                for (int k = 0; k < board.GetLength(1); k++)
                {
                    if (board[j, k] == "O" || board[j, k] == "X")
                    {
                        count++;
                    }
                }
                if (count == 9)
                {
                    return true;
                }
            }
            //If code makes it here then nothing was returned to this point
            return false;
        }
        public static bool isSpotTaken(String[,] board, int userSpot)
        {
            int row = -1;
            int col = -1;
            //assigns rows and cols per board spot
            if (userSpot == 1) { row = 0; col = 0; }
            else if (userSpot == 2) { row = 0; col = 2; }
            else if (userSpot == 3) { row = 0; col = 4; }
            else if (userSpot == 4) { row = 2; col = 0; }
            else if (userSpot == 5) { row = 2; col = 2; }
            else if (userSpot == 6) { row = 2; col = 4; }
            else if (userSpot == 7) { row = 4; col = 0; }
            else if (userSpot == 8) { row = 4; col = 2; }
            else if (userSpot == 9) { row = 4; col = 4; }
            //Checks if spot is taken
            try
            {
                if (board[row, col] == "X" || board[row, col] == "O")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    } 

}