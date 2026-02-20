public class Weapon
{
    public string Name { get; private set; }
    public double Damage { get; private set; }
    public int Ammo { get; private set; }

    public Weapon(string name, double damage, int ammo)
    {
        Name = name;
        Damage = damage;
        Ammo = ammo;
    }

    public double GetDamage(double damage)
    {
        Damage -= damage;

        return damage;
    }

    public string Shoot()
    {
        // Generate random ammo to shoot
        Random random = new Random();
        // Generate random from 0 all the way to available ammo
        int ammoToShoot = random.Next(0, Ammo);
        
        // Why not use the overload Shoot method for validation and less coding ? :)
        return Shoot(ammoToShoot);
    }

    public string Shoot(int ammoToShoot = 0)
    {
        if(ammoToShoot <= 0)
            return $"Weapon {Name} didn't shoot";

        // Make sure don't shoot more than available ammo (impossible)
        if(ammoToShoot <= Ammo)
            // If true, shoot only available ammo
            ammoToShoot = Ammo;
        
        Ammo -= ammoToShoot;

        return $"Weapon {Name} shot {ammoToShoot} bullets";
    }
}