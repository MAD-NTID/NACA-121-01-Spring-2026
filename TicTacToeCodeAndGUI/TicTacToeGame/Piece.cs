public abstract class Piece : IPiece
{
    private string owner;
    private char symbol;

    public Piece(string owner, char symbol)
    {
        this.symbol = symbol;
        this.owner = owner;
    }
    public string Owner => owner;

    public char Symbol => symbol;

    public override bool Equals(object? obj)
    {
        if(obj is null || !(obj is IPiece))
            return false;

        IPiece piece = (IPiece)obj;

        return piece.Symbol == this.Symbol && piece.Owner  == owner;
    }

    public override string ToString()
    {
        return $"{Owner} - {Symbol}";
    }
}
