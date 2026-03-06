public interface IBoard
{
    // GetCells (the 2d array of IPiece)
    public IPiece[,] GetCells { get; }

    public void Initialize();

    public bool Place(int row, int col, IPiece piece);

    public bool IsEmpty(int row, int col);

    public IPiece GetPiece(int row, int col);
}