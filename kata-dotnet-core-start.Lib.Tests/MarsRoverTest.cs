using kata_dotnet_core_start.Lib.Commands;

namespace kata_dotnet_core_start.Lib.Tests;

public class MarsRoverTest
{
    [Fact]
    public void ThereShouldBe25Positions()
    {
        //Arrange 
        var marsRoverPosition = new MarsRover();
        
        //Act
        var result = marsRoverPosition.TotalPositions();
        
        //Assert
        Assert.Equal(25, result);
    }
    
    [Fact]
    public void StartingPositionShouldBe_O_O()
    {
        //Arrange 
        var marsRover = new MarsRover();
        
        //Act
        var result = marsRover.StartingPosition();
        
        //Assert
        Assert.Equal("0:4", result);
    }
    
    [Fact]
    public void GetPositionsOfObstacles()
    {
        //Arrange 
        var marsRover = new MarsRover();
        
        //Act
        var result = marsRover.ObstaclePositions();
        
        //Assert
        Assert.Equal("0:2", result[0]);
        Assert.Equal("2:4", result[1]);
        Assert.Equal("4:1", result[2]);
    }
    
    [Fact]
    public void WhenGivingCommand_Right_Then_PositionShouldBeChanges()
    {
        //Arrange 
        var marsRover = new MarsRover();
        
        //Act
        var result = marsRover.Execute(new MoveRightCommand());
        
        //Assert
        Assert.True(result);

    }
}