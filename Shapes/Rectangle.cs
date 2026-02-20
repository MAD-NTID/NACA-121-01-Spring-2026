public class Rectangle : IShape
{
    public double Length { get; private set; }
    public double Width { get; private set; }

    public Rectangle(double length, double width)
    {
        if(length <= 0 || width <= 0 || (length == width))
            throw new Exception("This is not a rectangle");

        Length = length;
        Width = width;
    }

    public double Area()
    {
        return Length * Width;
    }

    public string Draw()
    {
        return $"Drawing a {GetType()} Shape";
    }

    public double Perimeter()
    {
        //  Incorrect, updates original values
        // Length *= 2;
        // Width *= 2;

        return (Length * 2) + (Width * 2);
    }
}