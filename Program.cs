using System;

namespace Jokenpo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = Jokenpo.GetPlayerMove("Luciana");
            Player player2 = Jokenpo.GetPlayerMove("Pedro");

            var gameResult = Jokenpo.Game(player1.Move, player2.Move);
            Jokenpo.DisplayResult(player1, player2, gameResult);
        }
    }
}
