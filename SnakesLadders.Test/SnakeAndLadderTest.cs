using SnakeAndLadderGame.Builder;
using SnakeAndLadderGame.Model;

namespace SnakeAndLadderGame.Test
{
    public class SnakeAndLadderTest
    {
        [Fact]
        public void CreateGame_InitialState_ShouldPlaceTokenOnSquare1ForAllPlayers()
        {
            // Arrange
            var game = GameBuilder.CreateGame()
                  .WithBoard(5)
                  .WithDice()
                  .WithPlayers(2)
                  .WithInitialPlayer(2)
                  .WithRules()
                  .Build();

            // Act
            foreach (var player in game.PlayerQueue) {
                // Assert
                Assert.Equal(1, player.CurrentCell.CellNumber);
            }

        }

        [Fact]
        public void CalculatePlayerPosition_PlayerOnSquare1AndRollDice3_ShouldPlaceTokenOnSquare4()
        {
            // Arrange
            var player = new Player(0);
            // Act
            var destinationCell = new Rules().CalculatePlayerPosition(player, 3, 20);
            // Assert
            Assert.Equal(4, destinationCell.CellNumber);
        }

        [Fact]
        public void CalculatePlayerPosition_PlayerOnSquare1AndRollDice3AndRollDice4_ShouldPlaceTokenOnSquare8()
        {
            // Arrange
            var player = new Player(0);
            var rules = new Rules();
            // Act
            var destinationCell = rules.CalculatePlayerPosition(player, 3, 20);
            destinationCell = rules.CalculatePlayerPosition(player, 4, 20);
            // Assert
            Assert.Equal(8, destinationCell.CellNumber);
        }

        [Fact]
        public void CalculatePlayerPosition_PlayerOnSquare97AndRollDice3_ShouldPlaceTokenOnSquare100AndPlayerWinsTheGame()
        {
            // Arrange
            var game = GameBuilder.CreateGame()
              .WithBoard(100)
              .WithDice()
              .WithPlayers(1)
              .WithInitialPlayer(1)
              .WithRules()
              .Build();

            var player = game.CurrentPlayer;
            player.CurrentCell.CellNumber = 97;
          
            // Act
            var destinationCell = game.Rules.CalculatePlayerPosition(player, 3, 100);
            // Assert
            Assert.True(game.Rules.PlayerWinsGame(game));
        }
    
    [Fact]
    public void CalculatePlayerPosition_PlayerOnSquare97AndRollDice4_ShouldStayTokenOnSquare97AndPlayerNotWinsTheGame()
    {
        // Arrange
        var game = GameBuilder.CreateGame()
          .WithBoard(100)
          .WithDice()
          .WithPlayers(1)
          .WithInitialPlayer(1)
          .WithRules()
          .Build();

        var player = game.CurrentPlayer;
        player.CurrentCell.CellNumber = 97;
        
        // Act
        var destinationCell = game.Rules.CalculatePlayerPosition(player, 4, 100);
        // Assert
        Assert.Equal(97, destinationCell.CellNumber);
        Assert.False(game.Rules.PlayerWinsGame(game));
    }

        [Fact]
        public void RollDice_GivenGameStarted_ShouldBeAlwaysBetween1And6()
        {
            // Testear funciones con resultado aleatorio es complejo por naturaleza, hay varias formas de tratar los unit test de este tipo
            // Un approach común es crear un interface IDice y mockearlo en los test con un resultado conocido

            // Arrange
            // Act
            var result = Dice.RollDice();
            // Assert
            Assert.True(result >= 1 && result <= 6);
        }

        [Fact]
        public void RollDice_ShowsResult4_ShouldMoveTheToken4PositionsForward()
        {
            // Arrange
            var rules = new Rules();
            var player = new Player(0);
            player.CurrentCell.CellNumber = 20;
            // Act
            var result = rules.CalculatePlayerPosition(player, 4, 50);
            // Assert
            Assert.Equal(24, result.CellNumber);
        }

        [Fact]
        public void RollDice_ShowsResult4AndNewPositionGreatherThanBoardSize_ShouldStayTokenInSameInitialPosition()
        {
            // Arrange
            var rules = new Rules();
            var player = new Player(0);
            player.CurrentCell.CellNumber = 47;
            // Act
            var result = rules.CalculatePlayerPosition(player, 4, 50);
            // Assert
            Assert.Equal(47, result.CellNumber);
        }
    }
}