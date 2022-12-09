using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public static class Constants
    {
        // Constantes para evitar magic numbers, también podría ser un json de configuración del juego
        public static int MaxDiceSides = 6;
        public static int MaxPlayers = 50;
        public static int MinBoardSize = 5;
        public static  int MaxBoardSize = 100;
    }
}
