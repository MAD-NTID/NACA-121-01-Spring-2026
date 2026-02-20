public interface IShape
{
    public double Length { get; }
    public double Width { get; }

    public double Area();
    public double Perimeter();
    public string Draw();
}