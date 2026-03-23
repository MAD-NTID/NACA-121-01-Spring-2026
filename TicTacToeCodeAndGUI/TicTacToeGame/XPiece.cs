public class XPiece : Piece
{
    public XPiece(string owner) : base(owner, 'X')
    {
    }

    public override bool Equals(object? obj)
    {
        if(obj is null || !(obj is XPiece))
            return false;
        
        return base.Equals(obj);
    }
}