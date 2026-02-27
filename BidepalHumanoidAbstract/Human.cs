public class Human : BipedalHumanoid
{
    public Human(string name, int age) : base(name, age)
    {
        
    }

    public override string Eat()
    {
        return "nom nom, make mess, where's the ketchup!";
    }

    public override string Talk()
    {
        return "Hello World. I know English and Spanish!";
    }
}