using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dalmuti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dalmuti!\n");

            Console.WriteLine("How many players are there?");
            int playerCount;
            Game mainGame = null;

            do
            {
                // if the user has entered a number between 3 and 8, inclusive
                if ((int.TryParse(Console.ReadLine(), out playerCount)) && playerCount >= 3 && playerCount <= 8)
                {
                    mainGame = new Game(playerCount);
                }
                else
                {
                    Console.WriteLine("Not a valid number of players (3-8 is valid). Let's try again, how many players are there?");
                }
            } while (mainGame == null);
        }
    }
}
