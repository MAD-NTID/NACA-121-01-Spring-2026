public class Board : IBoard
{
    private IPiece[,] cells;
    private int rows;
    private int cols;
    private BlankPiece blankPiece;

    public Board(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;

        this.cells = new Piece[rows,cols];
        this.blankPiece = new BlankPiece();
        this.Initialize();
    }

    public IPiece[,] Cells => cells;

    public void Initialize()
    {
        for(int row = 0; row < this.rows; row++)
            for(int col = 0; col < this.cols; col++)
                this.cells[row, col] = this.blankPiece;
    }

    public bool IsEmptySpot(int row, int col)
    {
        IPiece piece = this.Cells[row,col];
        return piece.Equals(this.blankPiece);
    }

    public bool Place(int row, int col, IPiece piece)
    {
        if(!this.IsEmptySpot(row, col))
            return false;
        
        this.cells[row,col] = piece;
        return true;
    }

    public IPiece GetPiece(int row, int col)
    {
        return this.cells[row,col];
    }
}