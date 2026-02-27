public class Alien : BipedalHumanoid
{
    public Alien(string name, int age) : base(name, age)
    {
        
    }

    public override string Eat()
    {
        return "eating balls of jelly full of proteins";
    }

    public override string Talk()
    {
        return "*#%&@)@ gibberish *#%*#(@ 983%&(@_)";
    }
}