using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame.Model
{
    public class Rules
    {
        public Player GetNextPlayer(Game game)
        {
            if (game.CurrentPlayer.Id < game.PlayerQueue.Length - 1)
            {
               // el jugador 1 está en la posición 0 de la cola, el jugador 2 en la posición 1, etc
                game.CurrentPlayer = game.PlayerQueue[(game.CurrentPlayer.Id + 1)];
            }
            else
            {
                game.CurrentPlayer = game.PlayerQueue[0];
            }
            return game.CurrentPlayer;
        }

        public Cell CalculatePlayerPosition(Player player, int diceNumber, int boardSize)
        {
            var moveLocation = player.CurrentCell.CellNumber;
            if ((moveLocation + diceNumber) <= boardSize)
            {
                moveLocation = moveLocation + diceNumber;
            }
            player.CurrentCell.CellNumber = moveLocation;
            return player.CurrentCell;
        }

        public bool PlayerWinsGame(Game game)
        {
            return game.CurrentPlayer.CurrentCell.CellNumber == game.Board.GameBoard.Length;
        }
    }
}
