public class Godzilla : Reptile
{
    public Godzilla(string name, int health, int damage) : base(name, health, damage)
    {
    }

    public override int AttackAbility()
    {
        int abilityAttackDamage = base.AttackAbility();

        Console.WriteLine($"{Name} attacks with Plasma Breath - Damage: {abilityAttackDamage}");

        return abilityAttackDamage;
    }

    public override bool Equals(object? obj)
    {
        // this calls the parent Equals()
        // return base.Equals(obj);

        // this compares itself to the obj
        return obj is Godzilla;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}