namespace kata_dotnet_core_start.Lib;

public class TickTacToe
{
    private Dictionary<int, string> Board = new()
    {
        {1,""},
        {2,""},
        {3,""},
        {4,""},
        {5,""},
        {6,""},
        {7,""},
        {8,""},
        {9,""}
    };

    // public string Winner { get; private set; }

    public int FilledBoard => Board.Where(x => x.Value != string.Empty).Count();

    public Dictionary<int, string> GetBoard()
    {
        return Board;
    }

    public bool Enter(int number)
    {
        if (number is < 1 or > 9)
            return false;

        if (Board[number] == "X" || Board[number] == "O")
            return false;

        if (FilledBoard == 0 || FilledBoard % 2 == 0)
            Board[number] =  "X";
        else
            Board[number] = "O";

        // _winner = CheckWinner();

        return true;
    }

    public string Winner()
    {
        return "X";
    }
}
