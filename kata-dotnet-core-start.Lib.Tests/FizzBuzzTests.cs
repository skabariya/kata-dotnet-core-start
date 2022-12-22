namespace kata_dotnet_core_start.Lib.Tests;

public class FizzBuzzTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(101)]
    public void Give_NumberWhichIsNotMultiplyBy3And5_When_Get_Then_ShouldReturnSameNumber(uint number)
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
    public void Give_NumberWhichIsMultiplyBy3_When_Get_Then_ShouldReturnFizz(uint number)
    {
        // Arrange
        // Act
        var result = FizzBuzz.Get(number);
        
        // Assert
        Assert.Equal("Fizz", result);
    }
    
    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void Give_NumberWhichIsMultiplyBy5_When_Get_Then_ShouldReturnBuzz(uint number)
    {
        // Arrange
        // Act
        var result = FizzBuzz.Get(number);
        
        // Assert
        Assert.Equal("Buzz", result);
    }
    
    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    [InlineData(90)]
    public void Give_NumberWhichIsMultiplyBy3And5_When_Get_Then_ShouldReturnFizzBuzz(uint number)
    {
        // Arrange
        // Act
        var result = FizzBuzz.Get(number);
        
        // Assert
        Assert.Equal("FizzBuzz", result);
    }
}