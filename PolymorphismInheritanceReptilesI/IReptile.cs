public interface IReptile
{
    public string Name { get; }

    // Do we need this??? we'll see
    public string Species { get; }

    // The max health, and the current health when attacked
    public int Health { get; }
    public int CurrentHealth { get; }

    // The base damage power to attack the opponent
    public int Damage { get; }

    // We need a way to allow the reptile to receive damage from opponent
    public void TakeDamage(int damage);

    // The attack (this is normal attack)
    public int Attack();
}