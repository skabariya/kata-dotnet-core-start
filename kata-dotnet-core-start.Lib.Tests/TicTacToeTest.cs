namespace kata_dotnet_core_start.Lib.Tests;

public class TicTacToeTest
{
    [Fact]
    public void Given_EmptyBoard_Then_Length_ShouldBe9()
    {
        // Act
        var ticTacToe = new TickTacToe();

        // Assert
        var board = ticTacToe.GetBoard();
        Assert.Equal(board.Count, 9);
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
        Assert.Equal(board[1], "X");
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
        Assert.Equal(board[1], "X");
        Assert.Equal(board[2], "O");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(10)]
    public void Given_Number_Outside_One_To_Nine_Then_Return_Error(int number)
    {
        // Arrange
        var ticTacToe = new TickTacToe();

        // Act
        var result = ticTacToe.Enter(number);

        // Assert
        Assert.Equal(result, false);
    }

    [Fact]
    public void Given_Number_One_Than_Same_Number_Should_Not_Be_Enter()
    {
        // Arrange
        var ticTacToe = new TickTacToe();
        ticTacToe.Enter(1);

        // Act
        var result = ticTacToe.Enter(1);

        // Assert
        Assert.Equal(result, false);
    }

    [Fact]
    public void Check_123_Winner_X()
    {
        // Arrange
        var ticTacToe = new TickTacToe();
        ticTacToe.Enter(1); // X
        ticTacToe.Enter(4); // o
        ticTacToe.Enter(2); // X
        ticTacToe.Enter(5); // o
        ticTacToe.Enter(3); // X

        // Act
        var result = ticTacToe.Winner();

        // Assert
        Assert.Equal(result, "X");
    }

    [Fact]
    public void Check_456_Winner_O()
    {
        // Arrange
        var ticTacToe = new TickTacToe();
        ticTacToe.Enter(1); // X
        ticTacToe.Enter(4); // o
        ticTacToe.Enter(2); // X
        ticTacToe.Enter(5); // o
        ticTacToe.Enter(9); // X
        ticTacToe.Enter(6); // o

        // Act
        var result = ticTacToe.Winner();

        // Assert
        Assert.Equal(result, "O");
    }

    [Fact]
    public void Check_If_There_Any_Winner_Three()
    {
        // Arrange
        var ticTacToe = new TickTacToe();
        ticTacToe.Enter(7); // X
        ticTacToe.Enter(4); // o
        ticTacToe.Enter(8); // X
        ticTacToe.Enter(5); // o
        ticTacToe.Enter(9); // X

        // Act
        var result = ticTacToe.Winner();

        // Assert
        Assert.Equal(result, "X");
    }

    [Fact]
    public void Check_789_Winner_O()
    {
        // Arrange
        var ticTacToe = new TickTacToe();
        ticTacToe.Enter(1); // X
        ticTacToe.Enter(7); // o
        ticTacToe.Enter(3); // X
        ticTacToe.Enter(8); // o
        ticTacToe.Enter(6); // X
        ticTacToe.Enter(9); // o

        // Act
        var result = ticTacToe.Winner();

        // Assert
        Assert.Equal(result, "O");
    }

    [Fact]
    public void Check_123_Winner_O()
    {
        // Arrange
        var ticTacToe = new TickTacToe();
        ticTacToe.Enter(4); // X
        ticTacToe.Enter(1); // o
        ticTacToe.Enter(5); // X
        ticTacToe.Enter(2); // o
        ticTacToe.Enter(9); // X
        ticTacToe.Enter(3); // o

        // Act
        var result = ticTacToe.Winner();

        // Assert
        Assert.Equal(result, "O");
    }

    [Fact]
    public void Check_147_Winner_X()
    {
        // Arrange
        var ticTacToe = new TickTacToe();
        ticTacToe.Enter(1); // X
        ticTacToe.Enter(2); // o
        ticTacToe.Enter(4); // X
        ticTacToe.Enter(5); // o
        ticTacToe.Enter(7); // X

        // Act
        var result = ticTacToe.Winner();

        // Assert
        Assert.Equal(result, "X");
    }

    [Fact]
    public void Check_147_Winner_O()
    {
        // Arrange
        var ticTacToe = new TickTacToe();
        ticTacToe.Enter(2); // X
        ticTacToe.Enter(1); // o
        ticTacToe.Enter(5); // X
        ticTacToe.Enter(4); // o
        ticTacToe.Enter(9); // X
        ticTacToe.Enter(7); // o

        // Act
        var result = ticTacToe.Winner();

        // Assert
        Assert.Equal(result, "O");
    }

    [Fact]
    public void Check_258_Winner_X()
    {
        // Arrange
        var ticTacToe = new TickTacToe();
        ticTacToe.Enter(2); // X
        ticTacToe.Enter(1); // o
        ticTacToe.Enter(5); // X
        ticTacToe.Enter(4); // o
        ticTacToe.Enter(8); // X

        // Act
        var result = ticTacToe.Winner();

        // Assert
        Assert.Equal(result, "X");
    }

    [Fact]
    public void Check_258_Winner_O()
    {
        // Arrange
        var ticTacToe = new TickTacToe();
        ticTacToe.Enter(1); // X
        ticTacToe.Enter(2); // o
        ticTacToe.Enter(4); // X
        ticTacToe.Enter(5); // o
        ticTacToe.Enter(9); // X
        ticTacToe.Enter(8); // o

        // Act
        var result = ticTacToe.Winner();

        // Assert
        Assert.Equal(result, "O");
    }

    [Fact]
    public void Check_369_Winner_X()
    {
        // Arrange
        var ticTacToe = new TickTacToe();
        ticTacToe.Enter(3); // X
        ticTacToe.Enter(2); // o
        ticTacToe.Enter(6); // X
        ticTacToe.Enter(5); // o
        ticTacToe.Enter(9); // X

        // Act
        var result = ticTacToe.Winner();

        // Assert
        Assert.Equal(result, "X");
    }
}
