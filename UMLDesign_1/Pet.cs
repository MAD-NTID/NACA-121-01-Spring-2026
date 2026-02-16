public class Pet : Species
{
    public Pet(string name, string sound)
    {
        // Invoke the Parent with Parameters
        new Species(name, sound);
    }
}