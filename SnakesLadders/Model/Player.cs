namespace SnakeLadderGame
{
    public class Player
    {
        // Aquí nos ajustamos a los requisitos. Posiblemente un jugador puede tener un name o nickname, pero para los casos
        // de uso que vamos a implementar, solo necesitamos un identificador o token y la casilla actual de cada jugador, que inicializamos
        // a 1 en el momento de crear al jugador, es decir,  colocamos al jugador en la casilla inicial del juego
        public int Id { get; set; }
        public Cell CurrentCell { get; set; }

        public Player (int id)
        {
            Id = id;
            CurrentCell = new Cell (1);
        }
    }
}
