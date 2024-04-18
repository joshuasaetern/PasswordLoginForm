using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //Next(lowest, highest+1) method upper bound exclusive
            /*
            int number = rand.Next(1, 101);
            if (number > 50)
            {
                Console.WriteLine($"You win! {number}");
            }
            else
            {
                Console.WriteLine($"You lose! {number}");
            }
            Console.ReadLine();
            */
            //Lets roll two six sided dice
            int sum = 0;
            int counter = 0;
            while (sum != 7)
            {
                counter++;
                Console.WriteLine($"Attempt: {counter}");
                sum = 0;
                int num1 = rand.Next(1, 7);
                int num2 = rand.Next(1, 7);
                sum = num1 + num2;
                if (sum == 7)
                {
                    Console.WriteLine($"You rolled a {num1} and a {num2}. You win!");
                }
                else
                {
                    Console.WriteLine($"You rolled a {num1} and a {num2}. Try again");
                    Console.WriteLine("Press enter to try again");
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
