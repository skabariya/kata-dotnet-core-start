using Xunit.Abstractions;

namespace kata_dotnet_core_start.Lib.Tests;

public class FizzBuzzStage1Tests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public FizzBuzzStage1Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(101)]
    public void Give_NumberWhichIsNotMultiplyBy3And5_When_Get_Then_ShouldReturnSameNumber(uint number)
    {
        // Act
        var result = new FizzBuzzStage1().Get(number);
        
        // Assert
        Assert.Equal(number.ToString(), result);
    }
    
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void Give_NumberWhichIsMultiplyBy3_When_Get_Then_ShouldReturnFizz(uint number)
    {
        // Act
        var result = new FizzBuzzStage1().Get(number);
        
        // Assert
        Assert.Equal("Fizz", result);
    }
    
    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void Give_NumberWhichIsMultiplyBy5_When_Get_Then_ShouldReturnBuzz(uint number)
    {
        // Act
        var result = new FizzBuzzStage1().Get(number);
        
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
        // Act
        var result = new FizzBuzzStage1().Get(number);
        
        // Assert
        Assert.Equal("FizzBuzz", result);
    }

    [Theory]
    [InlineData(1, 100)]
    public void Give_RangeOfNumber_When_Get_Then_ShouldReturnProperResult(int start, int end)
    {
        // Arrange
        var numbers = Enumerable.Range(start, end);
        
        // Assert
        foreach (var number in numbers)
        {
            var result = new FizzBuzzStage1().Get((uint)number);
            _testOutputHelper.WriteLine(result);
            if (IsMultipleOf3(number) && IsMultipleOf5(number))
                Assert.Equal("FizzBuzz", result);
            else if (IsMultipleOf3(number))
                Assert.Equal("Fizz", result);
            else if (IsMultipleOf5(number))
                Assert.Equal("Buzz", result);
            else
                Assert.Equal(number.ToString(), result);
        }
        
        bool IsMultipleOf3(int number) => number % 3 == 0;

        bool IsMultipleOf5(int number) => number % 5 == 0;
    }
    
}