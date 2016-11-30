using Xunit;

namespace RPS.Objects
{
  public class RockPaperScissorsTest
  {
    [Fact]
    public void GetWinner_BothPlayersSameChoice_Draw()
    {
      RockPaperScissors newGame = new RockPaperScissors("Player 1", "Player 2");
      newGame.SetPlayer1Choice(3);
      newGame.SetPlayer2Choice(3);
      Assert.Equal("Draw", newGame.GetWinner());
    }

    [Fact]
    public void GetWinner_Player1ScissorsPlayer2Paper_Player1Wins()
    {
      RockPaperScissors newGame = new RockPaperScissors("Player 1", "Player 2");
      newGame.SetPlayer1Choice(3);
      newGame.SetPlayer2Choice(2);
      Assert.Equal("Player 1 Wins!", newGame.GetWinner());
    }

    [Fact]
    public void GetWinner_Player2PaperPlayer1Rock_Player2Wins()
    {
      RockPaperScissors newGame = new RockPaperScissors("Player 1", "Player 2");
      newGame.SetPlayer1Choice(1);
      newGame.SetPlayer2Choice(2);
      Assert.Equal("Player 2 Wins!", newGame.GetWinner());
    }
    
    [Fact]
    public void GetWinner_Player2RockPlayer1Scissors_Player2Wins()
    {
      RockPaperScissors newGame = new RockPaperScissors("Player 1", "Player 2");
      newGame.SetPlayer1Choice(3);
      newGame.SetPlayer2Choice(1);
      Assert.Equal("Player 2 Wins!", newGame.GetWinner());
    }
  }
}
