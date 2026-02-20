public interface IShip
{
    public string Name { get; }
    public int Health { get; }
    public Weapon[] Weapons { get; }

    public void Fly();
    public string Shoot();
}