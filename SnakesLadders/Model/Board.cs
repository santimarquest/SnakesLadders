using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame.Model
{
    public class Board
    {
        public Cell[] GameBoard { get; set; }
        public Board(int boardSize)
        {
            // Vamos a crear un tablero entre 5 y 100 posiciones. Patrón de diseño factory => Es un método factory, en el que hacemos validaciones y aseguramos que obtenemos un 
            // tablero correcto. En casos más complejos se puede considerar la creación de una clase GameBoardFactory
            // También podríamos tener un método o clase PlayerFactory
            // Para el juego hemos creado una clase GameBuilder

            if (boardSize < Constants.MinBoardSize || boardSize > Constants.MaxBoardSize)
            {
                throw new ArgumentOutOfRangeException();
            }
            GameBoard = new Cell[boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                var cell = new Cell(i+1);
                GameBoard[i] = cell;
            }
        }
    }
}
