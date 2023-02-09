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
    public void StartingPositionShouldBe_0_4()
    {
        //Arrange 
        var marsRover = new MarsRover();
        
        //Act
        var result = marsRover.StartingPosition();
        
        //Assert
        Assert.Equal((uint)0, result.X);
        Assert.Equal((uint)4, result.Y);
    }

    [Fact]
    public void WhenGivingCommand_Right_Then_PositionShouldBe_1_4()
    {
        //Arrange 
        var marsRover = new MarsRover();
        
        //Act
        var result = marsRover.Execute(new MoveRightCommand());
        
        //Assert
        Assert.True(result);
        var currentPosition = marsRover.CurrentPosition(); 
        Assert.Equal((uint)1, currentPosition.X);
        Assert.Equal((uint)4, currentPosition.Y);
    }
    
    [Fact]
    public void WhenGivingCommand_ToMoveOnSameRightDirection_Then_PositionShouldBe_2_4()
    {
        //Arrange 
        var marsRover = new MarsRover();
        marsRover.Execute(new MoveRightCommand());
        
        //Act
        var result = marsRover.Execute(new MoveRightCommand());
        
        //Assert
        Assert.True(result);
        var currentPosition = marsRover.CurrentPosition(); 
        Assert.Equal((uint)2, currentPosition.X);
        Assert.Equal((uint)4, currentPosition.Y);
    }
    
    [Fact]
    public void WhenGivingCommand_Left_Then_PositionShouldBe_0_4()
    {
        //Arrange 
        var marsRover = new MarsRover();
        marsRover.Execute(new MoveRightCommand());
        
        //Act
        var result = marsRover.Execute(new MoveLeftCommand());
        
        //Assert
        Assert.True(result);
        var currentPosition = marsRover.CurrentPosition(); 
        Assert.Equal((uint)0, currentPosition.X);
        Assert.Equal((uint)4, currentPosition.Y);
    }
}