namespace kata_dotnet_core_start.Lib.Tests;

public class MarsRoverTest
{
    [Fact]
    public void ThereShouldBe25Positions()
    {
        //Arrange 
        var marsRoverPosition = new MarsRoverPosition();
        
        //Act
        var result = marsRoverPosition.TotalPositions();
        
        //Assert
        Assert.Equal(25, result);
    }
    
    [Fact]
    public void StartingPositionShouldBe_O_O()
    {
        //Arrange 
        var marsRoverPosition = new MarsRoverPosition();
        
        //Act
        var result = marsRoverPosition.Starting();
        
        //Assert
        Assert.Equal("0:0", result);
    }
    
    [Fact]
    public void GetPositionsOfObstacles()
    {
        //Arrange 
        var marsRoverPosition = new MarsRoverPosition();
        
        //Act
        var result = marsRoverPosition.Obstacles();
        
        //Assert
        Assert.Equal("0:2", result[0]);
        Assert.Equal("2:4", result[1]);
        Assert.Equal("4:1", result[2]);
    }
}