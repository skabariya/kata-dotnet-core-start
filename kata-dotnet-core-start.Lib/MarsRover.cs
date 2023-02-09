using kata_dotnet_core_start.Lib.Commands;

namespace kata_dotnet_core_start.Lib;

public class MarsRover
{
    public int TotalPositions()
    {
        return 25;
    }

    public string StartingPosition()
    {
        return "0:4";
    }

    public string[] ObstaclePositions()
    {
        return new[] { "0:2", "2:4", "4:1" };
    }

    public bool Execute(MoveRightCommand moveRightCommand)
    {
        return true;
    }
}