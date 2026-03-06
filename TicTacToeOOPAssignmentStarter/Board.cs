public class Board : IBoard
{
    public IPiece[,] GetCells => throw new NotImplementedException();

    public IPiece GetPiece(int row, int col)
    {
        throw new NotImplementedException();
    }

    public void Initialize()
    {
        throw new NotImplementedException();
    }

    public bool IsEmpty(int row, int col)
    {
        throw new NotImplementedException();
    }

    public bool Place(int row, int col, IPiece piece)
    {
        throw new NotImplementedException();
    }
}