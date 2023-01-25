namespace kata_dotnet_core_start.Lib;

public class TickTacToe
{
    private Dictionary<int, string> Board = new Dictionary<int, string>();

    public Dictionary<int, string> GetBoard()
    {
        return Board;
    }

    public bool Enter(int number)
    {
        if (number < 1 || number > 9)
            return false;
        if (Board.Count % 2 == 0)
            Board.Add(number, "X");
        else
            Board.Add(number, "O");
        return true;
    }
}
