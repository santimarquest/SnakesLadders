using SnakeLadderGame.Model;

namespace SnakeLadderGame
{
    public sealed class Game
    {
        // Un juego está formado por el material del juego (tablero y dado), una colección de jugadores, el jugador que empieza, y un conjunto de normas del juego

        // A efectos del juego, tanto el tablero como el dado podrían ser creados con un patrón singleton, ya que todos
        // los jugadores usan el mismo tablero y el mismo dado.
        // Si no veo una ganancia muy grande, no suelo utilitzar singleton para clases de modelo, sí para clases de infraestructura, como podría ser un logger
        // Se viola el principio de single responsability y es más difícil de testear
        // https://albertcapdevila.net/patron-diseno-singleton-csharp/

        public Board Board { get; set; }
        public Dice Dice { get; set; }

        public Player[] PlayerQueue { get; set; }
        public Player CurrentPlayer { get; set; }

        public Rules Rules { get; set; }

    }
}
