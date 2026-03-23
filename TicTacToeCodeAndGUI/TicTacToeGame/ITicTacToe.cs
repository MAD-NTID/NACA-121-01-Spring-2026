public interface ITicTacToe
{
    public bool IsGameOver { get; }
    public IPiece[] Players { get; }
    public IPiece Winner { get; }
    public IPiece Turn { get; }
    public bool IsBoardFull { get; }

    public IPiece GetPiece(int row, int col);

    public void AddPlayers(string player1, string player2);
    public bool Place(int row, int col);

    public bool GameWonHorizontial();
    public bool GameWonVertical();

    public bool GameWonDiagonal1();
    public bool GameWonDiagonal2();

    public void Restart();

   

    
}