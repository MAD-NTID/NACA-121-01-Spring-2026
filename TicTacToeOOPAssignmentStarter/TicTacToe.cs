public class TicTacToe : ITicTacToe
{
    public IBoard Board { get; private set; }
    public IPiece[] Players { get; private set; }
    
    // This is to tell the game who's turn it is (use the actual object)
    public IPiece Turn { get; private set; }

    // This is to tell the game who's the winner (use the actual object)
    public IPiece Winner { get; private set; }

    public bool IsGameOver => throw new NotImplementedException();

    public bool IsBoardFull => throw new NotImplementedException();

    public void AddPlayers(string player1, string player2)
    {
        throw new NotImplementedException();
    }

    public bool GameWonDiagonal1()
    {
        throw new NotImplementedException();
    }

    public bool GameWonDiagonal2()
    {
        throw new NotImplementedException();
    }

    public bool GameWonHorizontial()
    {
        throw new NotImplementedException();
    }

    public bool GameWonVertical()
    {
        throw new NotImplementedException();
    }

    public IPiece GetPiece(int row, int col)
    {
        throw new NotImplementedException();
    }

    public bool Place(int row, int col)
    {
        throw new NotImplementedException();
    }

    public void Restart()
    {
        throw new NotImplementedException();
    }
}