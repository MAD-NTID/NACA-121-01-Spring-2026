public class Species : ISpecies
{
    public string Name { get; private set; }
    public string Sound { get; private set; }
    
    public Species()
    {
        Name = "Undefined Species";
        Sound = "N/A";
    }

    public Species(string name, string sound)
    {
        Name = name;
        Sound = sound;
    }

    public string GetName()
    {
        return Name;
    }

    public string MakeSound()
    {
        return Sound;
    }
}