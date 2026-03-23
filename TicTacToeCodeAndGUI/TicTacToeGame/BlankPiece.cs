public class BlankPiece : Piece
{
    public BlankPiece() : base("None", 'N')
    {
    }

    public override bool Equals(object? obj)
    {
        if(obj is null || !(obj is BlankPiece))
            return false;
        
        IPiece piece = (BlankPiece)obj;

        return base.Equals(piece);
    }
}