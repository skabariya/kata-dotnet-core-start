namespace kata_dotnet_core_start.Lib.Tests;

public class TicTacToeTest
{
    [Fact]
    public void Test1()
    {
        // Act
        var ticTacToe = new TickTacToe();
        ticTacToe.Enter(1);
        ticTacToe.Enter(2);

        // Assert
        var board = ticTacToe.GetBoard();
        Assert.Equal(board.Count, 2);
        Assert.Equal(board[1], "X");
        Assert.Equal(board[2], "O");
    }
}
