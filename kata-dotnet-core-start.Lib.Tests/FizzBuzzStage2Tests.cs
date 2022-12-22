namespace kata_dotnet_core_start.Lib.Tests;

public class FizzBuzzStage2Tests
{
    [Theory]
    [InlineData(9)]
    public void Give_NumberIsDividedBy3_ButNotContains3Or5_When_Get_Then_ShouldReturnFizz(uint number)
    {
        // Act
        var result = new FizzBuzzStage2().Get(number);
        
        // Assert
        Assert.Equal("Fizz", result);
    }
    
    [Theory]
    [InlineData(13)]
    [InlineData(31)]
    public void Give_NumberIsNotDividedBy3AndContains3_Then_Get_Then_ShouldReturnFizz(uint number)
    {
        // Act
        var result = new FizzBuzzStage2().Get(number);
        
        // Assert
        Assert.Equal("Fizz", result);
    }
}