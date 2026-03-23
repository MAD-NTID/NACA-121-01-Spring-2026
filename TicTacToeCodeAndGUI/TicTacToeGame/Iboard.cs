public interface IBoard
{
    public IPiece[,] Cells{get;}

    public void Initialize();

    public bool Place(int row, int col, IPiece piece);

    public bool IsEmptySpot(int row, int col);

    public IPiece GetPiece(int row, int col);
    
}