using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    public static class Jokenpo
    {

        public static Player GetPlayerMove(string playerName)
        {
            Console.WriteLine($"1 - Rock, 2 - Paper, 3 - Scissors.");
            Console.WriteLine($"Player {playerName}: ");
            int.TryParse(Console.ReadLine(), out int playerMove);
            return new Player(playerName, (EJokenpo)playerMove);
        }

        public static void DisplayResult(Player player1, Player player2, EJokenpo gameResult)
        {
            if (gameResult == player1.Move)
            {
                Console.WriteLine($"{player1.Move} beats {player2.Move}");
                Console.WriteLine($"{player1.Name} wins!");
            }
            else if (gameResult == player2.Move)
            {
                Console.WriteLine($"{player2.Move} beats {player1.Move}");
                Console.WriteLine($"{player2.Name} wins!");
            }
            else
            {
                Console.WriteLine("Invalid Move!");
            }
        }
        public static EJokenpo Game(EJokenpo moveOne, EJokenpo moveTwo)
        {
            bool rock = moveOne == EJokenpo.ROCK && moveTwo == EJokenpo.SCISSOR
                || moveTwo == EJokenpo.ROCK && moveOne == EJokenpo.SCISSOR;
            bool paper = moveOne == EJokenpo.PAPER && moveTwo == EJokenpo.ROCK
                || moveTwo == EJokenpo.PAPER && moveOne == EJokenpo.ROCK;
            bool scissor = moveOne == EJokenpo.PAPER && moveTwo == EJokenpo.SCISSOR
                || moveTwo == EJokenpo.PAPER && moveOne == EJokenpo.SCISSOR;


            if (rock)
            {
                return EJokenpo.ROCK;
            }
            else if (paper)
            {
                return EJokenpo.PAPER;
            }
            else if (scissor)
            {
                return EJokenpo.SCISSOR;
            }
            else
            {
                return EJokenpo.INVALID;
            }
        }
    }
}
