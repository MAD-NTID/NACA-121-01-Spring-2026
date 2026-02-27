// Parent is Reptile, IReptile is Interface
public class Reptile : IReptile
{
    public string Name { get; private set; }

    // The max health of the reptile
    public int Health { get; private set; }

    public int CurrentHealth { get; private set; }

    public int Damage { get; private set; }

    public Reptile(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        CurrentHealth = health;
        Damage = damage;
    }

    public int Attack()
    {
        // Just return the damage that this reptile can cause
        Random random = new Random();
        // 15% chance that critical will occur
        if(random.Next(0, 101) > 85)
        {
            double extraDamage = 1 + (random.Next(1, 6) / 100);
            return (int) (Damage * extraDamage);
        }

        return Damage;
    }

    public void TakeDamage(int damage)
    {
        // Reduce the current health from the damage taken by the opponent
        CurrentHealth -= damage;
    }

    public override string ToString()
    {
        return  $"Type: {base.ToString()}\n" + 
                $"Name: {Name}\n" +
                $"Health: {Health}\n" +
                $"Current Health: {CurrentHealth}\n" + 
                $"Damage: {Damage}";
    }

    // Add the keyword 'virtual' before the type
    // This makes the method overridable by the child class
    // Meaning, you provide flexibility to the child classes to 
    // Override and do different behaviors and still honoring
    // Inheritance Rules.
    public virtual int AttackAbility()
    {
        Random random = new Random();

        // We'll need to convert this to percentage
        double attackPower = 1 + (random.Next(15, 21) / 100.0);

        // Convert this to an integer
        return (int) (Damage * attackPower);
    }

    // Checks if object is a child of Reptile
    public override bool Equals(object? obj)
    {
        // Hey, are you (obj) my kid!?
        return obj is Reptile;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}