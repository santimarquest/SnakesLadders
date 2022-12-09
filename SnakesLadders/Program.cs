using SnakeAndLadderGame;
using SnakeAndLadderGame.Model;

// En el programa principal tenemos el loop del juego
var game = new Play().Start();
var hayGanador = false;
while (!hayGanador)
{
   Console.WriteLine();
   var player = game.Rules.GetNextPlayer(game);
   var tirada = Dice.RollDice();
    Console.WriteLine("Jugador " + player.Id.ToString() + ", tu dado muestra " + tirada.ToString());
    player.CurrentCell = game.Rules.CalculatePlayerPosition(player, tirada, game.Board.GameBoard.Length);
    Console.WriteLine("Jugador " + player.Id.ToString() + ", tu posición es " + player.CurrentCell.CellNumber.ToString());
    hayGanador = game.Rules.PlayerWinsGame(game);
}

Console.WriteLine("El ganador es el jugador " + game.CurrentPlayer.Id.ToString());
Console.ReadLine();
