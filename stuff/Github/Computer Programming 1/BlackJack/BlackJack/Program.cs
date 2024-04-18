using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //blackjack 0.5%
            Random rand = new Random();
            double houseEdge = 0.005;
            int balance = 1000;
            int currentBalance = balance;
            int wager = 25;
            int gamesPlayed = 0;
            while (currentBalance > 0 && currentBalance < (balance * 2))
            {
                double playerChance = rand.NextDouble();
                double houseChance = rand.NextDouble() * (1 + houseEdge);
                if (playerChance > houseChance)
                {
                    currentBalance += wager;
                }
                else
                {
                    currentBalance -= wager;
                }
                gamesPlayed++;
            }
            if (currentBalance <= 0)
            {
                Console.WriteLine($"You went broke, dont go to the ATM");
            }
            else
            {
                Console.WriteLine($"You win, double up");
            }
            Console.WriteLine($"Games played {gamesPlayed}");
            Console.ReadLine();
        }
    }
}
