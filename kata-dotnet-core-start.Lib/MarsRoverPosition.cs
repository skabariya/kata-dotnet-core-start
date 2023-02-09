namespace kata_dotnet_core_start.Lib;

public class MarsRoverPosition
{
    public int TotalPositions()
    {
        return 25;
    }

    public string Starting()
    {
        return "0:0";
    }

    public string[] Obstacles()
    {
        return new[] { "0:2", "2:4", "4:1" };
    }
}