// Parent is Reptile, Child is Dragon
public class Dragon : Reptile
{
    // When inheriting from parent, but invoke parent's base constructor
    public Dragon(string name, int health, int damage) : base(name, health, damage)
    {
        
    }

    public override int AttackAbility()
    {
        int abilityAttackDamage = base.AttackAbility();

        Console.WriteLine($"{Name} attacks with Fire Breathe - Damage: {abilityAttackDamage}");

        return abilityAttackDamage;
    }

    public override bool Equals(object? obj)
    {
        // this calls the parent Equals()
        // return base.Equals(obj);

        // this compares itself to the obj
        // return obj is Dragon;

        // Logical Comparison - exact values comparison
        // No longer a Type comparison
        return obj is Dragon dragon &&
                    dragon.Name == Name && 
                    dragon.Health == Health && 
                    dragon.Damage == Damage;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}