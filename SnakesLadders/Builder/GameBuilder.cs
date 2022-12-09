using SnakeLadderGame.Model;

namespace SnakeLadderGame.Builder
{
    // El builder es para que en la construcción de los elementos necesarios para el juego, se puedan hacer validaciones,
    // para garantizar que si el builder permite la creación del juego, estamos con un tablero,  un dado, y unos jugadores correctamente creados
    // Se pueden lanzar excepciones si no fuera posible la creación de alguno de los elementos necesarios para el juego
    // He usado el fluentbuilder explicado en https://albertcapdevila.net/patron-builder-csharp-net/
    public class GameBuilder
    {
        private Game _game { get; set; }

        public static GameBuilder CreateGame()
        {
            return new GameBuilder();
        }

        private GameBuilder() {
            _game = new Game();
        }

        public GameBuilder WithBoard (int boardSize)
        {
          _game.Board= new Board(boardSize);
          return this;
        }

        public GameBuilder WithDice()
        {
            _game.Dice = new Dice();
            return this;
        }

        public GameBuilder WithPlayers (int numberOfPlayers)
        {
            _game.PlayerQueue= new Player[numberOfPlayers];
            for (int i = 0; i < numberOfPlayers; i++)
            {
                _game.PlayerQueue[i] = new Player(i);
            }
            return this;
        }

        public GameBuilder WithInitialPlayer(int numberOfPlayers)
        {
            Random rnd = new Random();
            var index = rnd.Next(1, numberOfPlayers);
            _game.CurrentPlayer = _game.PlayerQueue[index - 1];
            return this;
        }

        public GameBuilder WithRules()
        {
            _game.Rules = new Rules();
            return this;
        }

        public Game Build()
        {
            // Después del build estamos seguros que tenemos un objeto game bien construido, con su tablero, su dado, los jugadores y el jugador inicial asignado
            return _game;
        }

    }
}
