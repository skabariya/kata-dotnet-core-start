namespace kata_dotnet_core_start.Lib.Tests;

public class TicTacToeTest
{
    [Fact]
    public void Test1()
    {
        // Act
        var ticTacToe = new TickTacToe();
        var board = ticTacToe.GetBoard();

        // Assert
        Assert.Equal(Array.Empty<int>(), board);
    }
}