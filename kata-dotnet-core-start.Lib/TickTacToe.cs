namespace kata_dotnet_core_start.Lib;

public class TickTacToe
{
    private Dictionary<int, string> Board = new Dictionary<int, string>();

    public Dictionary<int, string> GetBoard()
    {
        return Board;
    }

    public void Enter(int number)
    {
        if (Board.Count % 2 == 0)
            Board.Add(number, "X");
        else
            Board.Add(number, "O");
    }
}
