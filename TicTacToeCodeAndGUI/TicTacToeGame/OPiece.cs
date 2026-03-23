public class OPiece : Piece
{
    public OPiece(string owner) : base(owner, 'O')
    {
    }

    public override bool Equals(object? obj)
    {
        if(obj is null || !(obj is OPiece))
            return false;
        
        return base.Equals(obj);
    }
}