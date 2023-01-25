namespace kata_dotnet_core_start.Lib.Tests;

public class TicTacToeTest
{
    [Fact]
    public void Given_EmptyBoard()
    {
        // Act
        var ticTacToe = new TickTacToe();

        // Assert
        var board = ticTacToe.GetBoard();
        Assert.Equal(board.Count, 0);
    }

    [Fact]
    public void Given_Player_X_Just_Played_Then_Turn_Goes_To_O()
    {
        // Arrange
        var ticTacToe = new TickTacToe();
        ticTacToe.Enter(1);

        // Act
        ticTacToe.Enter(2);

        // Assert
        var board = ticTacToe.GetBoard();
        Assert.Equal(board.Count, 2);
        Assert.Equal(board[1], "X");
        Assert.Equal(board[2], "O");
    }

    [Fact]
    public void Given_new_game_Then_X_is_first_move()
    {
        // Arrange
        var ticTacToe = new TickTacToe();

        // Act
        ticTacToe.Enter(1);

        // Assert
        var board = ticTacToe.GetBoard();
        Assert.Equal(board.Count, 1);
        Assert.Equal(board[1], "X");
    }
}
