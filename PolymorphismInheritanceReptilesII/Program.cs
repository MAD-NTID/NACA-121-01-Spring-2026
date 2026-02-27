Reptile drogon = new Dragon("Drogon", 1000, 100);
Reptile godzilla = new Godzilla("Godzilla 1954", 1000, 100);

Console.WriteLine("==========Battle Begin!==========");

Random random = new Random();
int round = 1;

// CurrentHealth is the health that changes
while(drogon.CurrentHealth > 0 && godzilla.CurrentHealth > 0)
{
    Console.WriteLine($"Current Round: {round++}");

    // Determine ability attack for drogon
    int drogonCritical = random.Next(1, 4);
    // This is ternary operator - a short hand version of if/else
    int drogonDamage = drogonCritical != 3
        ? drogon.Attack()
        : drogon.AttackAbility();

    godzilla.TakeDamage(drogonDamage);
    Console.WriteLine($"{godzilla.Name} took damage {drogonDamage}");
    Console.WriteLine($"Health: {godzilla.CurrentHealth}/{godzilla.Health}");
    Console.WriteLine();

    // Check if Godzilla can continue to battle
    if(godzilla.CurrentHealth <= 0)
        break;

    // Determine ability attack for godzilla
    int godzillaCritical = random.Next(1, 4);
    // This is ternary operator - a short hand version of if/else
    int godzillaDamage = godzillaCritical != 3
        ? godzilla.Attack()
        : godzilla.AttackAbility();

    drogon.TakeDamage(godzillaDamage);
    Console.WriteLine($"{drogon.Name} took damage {godzillaDamage}");
    Console.WriteLine($"Health: {drogon.CurrentHealth}/{drogon.Health}");
    Console.WriteLine();

    // Check if Drogon can continue to battle
    if(drogon.CurrentHealth <= 0)
        break;

    Console.WriteLine($"==========End of Round {round}==========");
}

Console.WriteLine("==========Battle Over!==========");

// Determine the winner
if(drogon.CurrentHealth > godzilla.CurrentHealth)
{
    Console.WriteLine($"{drogon.Name} Won!");
}
else
{
    Console.WriteLine($"{godzilla.Name} Won!");
}