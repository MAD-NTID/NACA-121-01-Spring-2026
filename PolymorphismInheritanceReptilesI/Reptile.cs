public class Reptile : IReptile
{
    public string Name { get; private set; }

    public int Health { get; private set; }

    public int CurrentHealth { get; private set; }

    public int Damage { get; private set; }

    public Reptile(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public int Attack()
    {
        // Just return the damage that this reptile can cause
        return Damage;
    }

    public void TakeDamage(int damage)
    {
        // Reduce the current health from the damage taken by the opponent
        CurrentHealth -= damage;
    }

    public override string ToString()
    {
        return $"Type: {base.ToString()}\nName: {Name}\nHealth: {Health}\nDamage: {Damage}";
    }
}