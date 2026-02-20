public class Ship : IShip
{
    public string Name { get; private set; }

    public int Health { get; private set; }

    public Weapon[] Weapons { get; private set; }

    public Ship(string name, int health, Weapon[] weapons)
    {
        Name = name;
        Health = health;
        Weapons = weapons;
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }

    public string Shoot()
    {
        throw new NotImplementedException();
    }
}