int Selection()
{
    Console.WriteLine("StarFleet Federation");

    Console.WriteLine("Menu");
    Console.WriteLine("========================");
    Console.WriteLine("1. Add Alien to Ship");
    Console.WriteLine("2. Fly");
    Console.WriteLine("3. Fly at Specific Speed");
    Console.WriteLine("4. Remove Alien from Ship");
    Console.WriteLine("5. Show Ship Information");
    Console.WriteLine("6. Exit");
    Console.Write("Selection: ");

    string userInput = Console.ReadLine();
    int input = 0; //   default
    
    // In your loop in implement a try and catch exception. You only need to catch the FormatException and display “Invalid selection. Input must be a digit!”
    try
    {
        input = int.Parse(userInput);
    }
    catch(FormatException fe)
    {}

    return input;
}

// Create a new ship instance with the name voyager and an initial capacity of 3000 alien crew.
Ship ship = new Ship("Voyager", 3000);

// Create a loop that allow the user to perform an operation from the menu until the user decided to exit.
while(true)
{
    int input = Selection();

    if(input == 1)
    {
        string name, role;
        Alien alien;

        // Prompt and validate crew member's name
        // Use a loop to re-prompt
        do
        {
            Console.Write("Enter the name of the Alien Crew: ");
            name = Console.ReadLine();

            Console.Write($"Enter the role for {name}: " );
            role = Console.ReadLine();

            // Overwrite the old alien object placeholder with new values
            alien = new(name, role);

            if(!ship.Add(alien))
            {
                Console.WriteLine("Only 1 Captain or 1 Chief Officer Allowed");
            }
        } while(!ship.Add(alien));

        Console.WriteLine($"{alien} was added successfully!");
    }
    /*
    o	Invoke the Fly() method
    o	Display “{ship name } flew {ship distance} interstellar distance at {warps peed}  warp speed”
    */
    else if(input == 2)
    {
        ship.Fly();
        Console.WriteLine($"{ship.Name} flew {ship.TotalDistanceTraveled} interstellar distance at warp speed {ship.CurrentWarpSpeed}");
    }
    else if(input == 3)
    {
        Console.Write("Enter a Warp Speed in Multiples of 3: ");
        if(int.TryParse(Console.ReadLine(), out int warpSpeed) && warpSpeed % 3 == 0)
        {
            ship.Fly(warpSpeed);
            Console.WriteLine($"{ship.Name} flew {ship.TotalDistanceTraveled} interstellar distance at warp speed {ship.CurrentWarpSpeed}");
        }
        else
        {
            Console.WriteLine("Invalid speed! Speed must be an integer in mutliple of 3!\n Ship did not fly!");
        }
    }
    else if(input == 4)
    {
        Console.Write("Enter the Alien's Name to Remove: ");
        string name = Console.ReadLine();

        if(ship.Remove(name))
        {
            Console.WriteLine($"{name} was successfully removed");
        }
        else
        {
            Console.WriteLine($"{name} doesn't exist");
        }
    }
    else if(input == 5)
    {
        Console.WriteLine(ship);
    }
    else if(input == 6)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Menu Choice");
    }

    // Add spacing for each iteration
    Console.WriteLine();
}

Console.WriteLine("Thank you for flying with us!");