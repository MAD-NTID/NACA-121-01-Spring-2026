public class Car
{
    public string Make { get; private set; }

    private string model;
    public string Model
    {
        get { return model; }
        set { 
            if(string.IsNullOrEmpty(value))
                value = "Model Not Set";

            model = value; 
        }
    }

    public string Color { get; private set; }

    public double Price { get; private set; }

    public Car(string make, string model, string color, double price)
    {
        Make = make;
        Model = model;
        Color = color;
        Price = price;
    }

    public override string ToString()
    {
        return $"Make: {Make}\n" + 
        $"Model: {Model}\n" +
        $"Color: {Color}\n" + 
        $"Price: {Price:c}";
    }
}