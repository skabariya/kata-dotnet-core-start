﻿namespace kata_dotnet_core_start.Lib;

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
        if (Board[4] != string.Empty && Board[4] == Board[5] && Board[5] == Board[6])
        {
            return Board[4];
        }
        if (Board[7] != string.Empty && Board[7] == Board[8] && Board[8] == Board[9])
        {
            return Board[7];
        }
        return "X";
    }
}
