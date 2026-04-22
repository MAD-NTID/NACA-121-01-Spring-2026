public class Book
{
    //  Lambda Expression + Ternary Operator
    private string? title;
    public string? Title => !string.IsNullOrEmpty(title) ? title: "No Title";

    //  Lambda Expression + Ternary Operator
    private string? author;
    public string? Author => !string.IsNullOrEmpty(author) ? author: "No Author";

    //  Lambda Expression + Ternary Operator (Don't allow negatives)
    private double price;
    public double Price => price >= 0 ? price : 0;

    public Book(string? title, string? author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Lambda Expression
    public override string ToString() => $"Title: {Title}\nAuthor: {Author}\nPrice: {Price:C}";
}