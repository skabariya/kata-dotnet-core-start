namespace kata_dotnet_core_start.Lib.Tests;

public class MarsRoverTest
{
    [Fact]
    public void ThereShouldBe25Positions()
    {
        //Act
        var result = MarsRoverPosition.TotalPositions();
        
        //Assert
        Assert.Equal(25, result);
    }
}