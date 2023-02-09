namespace kata_dotnet_core_start.Lib;

public class Position
{
    private bool _obstacles;
    private uint _x;
    private uint _y;
    public uint X => _x;
    public uint Y => _y;

    public void MarkAsObstacle()
    {
        _obstacles = true;
    }
    
    public bool SetX(uint value)
    {
        if (value > 4) 
            return false;
        
        _x = value;
        return true;
    }
    
    public bool SetY(uint value)
    {
        if (value > 4) 
            return false;
        
        _y = value;
        return true;
    }
}