public class Card
{
    public string? Suit { 
        get; private set; 
    }
    public string? Color { get; private set; }
    public int Number { get; private set; }

    public Card(string? suit, string? color, int number)
    {
        Suit = suit;
        Color = color;
        Number = number;
    }

    public override string ToString()
    {
        return $"Card: {Color} {Number} of {Suit}";
    }
}