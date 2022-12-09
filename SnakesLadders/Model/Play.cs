using SnakeAndLadderGame.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame.Model
{
    public class Play
    {
        public Game Start()
        {
            // Podemos hacer validaciones de estos parámetros....
            int boardSize = 0;
            while (boardSize == 0 || boardSize < Constants.MinBoardSize || boardSize > Constants.MaxBoardSize) { 
                Console.WriteLine("Tamaño del tablero, entre 5 y 100:");
                int.TryParse(Console.ReadLine(), out boardSize);
            }

            int numberOfPlayers = 0;
            while (numberOfPlayers == 0 || numberOfPlayers < 1 || numberOfPlayers > Constants.MaxPlayers)
            {
                Console.WriteLine("Número de jugadores, entre 1 y 50:");
                int.TryParse(Console.ReadLine(), out numberOfPlayers);
            }

            Console.WriteLine("Empieza el juego!!!!!");

            // Este es el método que vamos a usar para la creación del juego, con todos sus elementos       
                var game = GameBuilder.CreateGame()
                    .WithBoard(boardSize)
                    .WithDice()
                    .WithPlayers(numberOfPlayers)
                    .WithInitialPlayer(numberOfPlayers)
                    .WithRules()
                    .Build();

            // Aquí tenemos un juego con su tablero, su dado, todos los jugadores, el jugador que debe empezar el juego, y las normas del juego

            return game;
        }
    }
}
