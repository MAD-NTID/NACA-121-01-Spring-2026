public class Shape : IShape
{
    public string Name { get; set; }

    public double Length => throw new NotImplementedException();

    public double Width => throw new NotImplementedException();

    public Shape(string name)
    {
        Name = name;
    }

    public double Area()
    {
        throw new NotImplementedException();
    }

    public double Perimeter()
    {
        throw new NotImplementedException();
    }

    public string Draw()
    {
        return $"Drawing a {Name} Shape";
    }
}