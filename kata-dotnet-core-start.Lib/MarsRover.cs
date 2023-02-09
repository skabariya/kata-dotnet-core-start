using kata_dotnet_core_start.Lib.Commands;

namespace kata_dotnet_core_start.Lib;

public class MarsRover
{
    private Position _currentPosition;
    private Position _startingPosition;

    public MarsRover()
    {
        _startingPosition = new Position();
        _startingPosition.SetX(0);
        _startingPosition.SetY(4);
        _currentPosition = _startingPosition;
    }
    
    public int TotalPositions()
    {
        return 25;
    }

    public Position StartingPosition()
    {
        return _startingPosition;
    }

    public bool Execute(MoveRightCommand moveRightCommand)
    {
        return _currentPosition.SetX(_currentPosition.X + 1);
    }

    public Position CurrentPosition()
    {
        return _currentPosition;
    }
}