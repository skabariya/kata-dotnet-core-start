namespace kata_dotnet_core_start.Lib.Tests;

public class FizzBuzzTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    public void Give_NumberWhichIsNotMultiplyBy3_When_Get_Then_ShouldReturnSameNumber(int number)
    {
        // Arrange
        // Act
        var result = FizzBuzz.Get(number);
        
        // Assert
        Assert.Equal(number.ToString(), result);
    }
    
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void Give_NumberWhichIsMultiplyBy3_When_Get_Then_ShouldReturnFizz(int number)
    {
        // Arrange
        // Act
        var result = FizzBuzz.Get(number);
        
        // Assert
        Assert.Equal("Fizz", result);
    }
}