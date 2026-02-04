Console.WriteLine("Welcome to NACA-121 Car Shop");
Console.WriteLine("============================\n");

Car[] cars = new Car[1000];
int carTracker = 0;

while(true)
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Create a new Car");
    Console.WriteLine("2. Remove a Car");
    Console.WriteLine("3. Show Cars");
    Console.WriteLine("4. Update a Car");
    Console.WriteLine("5. Exit Car Shop");

    Console.Write("Select an Action: ");

    string? input = Console.ReadLine();

    if(input == "1")
    {
        string? make = null, model = null, color = null;
        double price = 0;

        // Validate make
        while(string.IsNullOrEmpty(make))
        {
            Console.Write("Enter the make of the car: ");
            make = Console.ReadLine();
        }

        // Validate model
        while(string.IsNullOrEmpty(model))
        {
            Console.Write("Enter the model of the car: ");
            model = Console.ReadLine();
        }

        // Validate color
        while(string.IsNullOrEmpty(color))
        {
            Console.Write("Enter the color of the car: ");
            color = Console.ReadLine();
        }

        // if price is less than or equal to 0, it will loop again
        while(price <= 0)
        {
            Console.Write("Enter the price of the car: ");

            // If price does not parse, it will loop again
            if(!double.TryParse(Console.ReadLine(), out price) || price <= 0)
            {
                Console.WriteLine("Invalid Price");
            }

            Console.WriteLine();
        }

        Car car = new(make, model, color, price);
        cars[carTracker] = car;
        carTracker++;

        Console.WriteLine($"Successfully created: {car}");
    }
    else if(input == "2")
    {
        // Show a listing of cars that are not null to the customer, and the list number
        for(int i = 0; i < cars.Length; i++)
        {
            Car theCar = cars[i];

            if(theCar != null)
            {
                Console.WriteLine($"{i + 1} - {theCar}");
            }
        }

        Console.WriteLine();

        int vehicleChoice;
        while(true)
        {
            Console.Write("Select a Vehicle to Remove (option #): ");   

            if(int.TryParse(Console.ReadLine(), out vehicleChoice) && 
                vehicleChoice >= 1 && vehicleChoice <= cars.Length)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Vehicle Choice");
            }
        }        

        // Convert to zero base
        vehicleChoice --;

        Car removedCar = cars[vehicleChoice];
        cars[vehicleChoice] = null;

        Console.WriteLine($"Car Removed:\n{removedCar}");
    }
    else if(input == "3")
    {
        bool carsFound = false;
        for(int i = 0; i < cars.Length; i++)
        {
            Car theCar = cars[i];

            if(theCar != null)
            {
                Console.WriteLine($"{theCar}");
                carsFound = true;
            }
        }

        if(!carsFound)
            Console.WriteLine("No Cars found");
    }
    else if(input == "4")
    {
        
    }
    else if(input == "5")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Selection");
    }   
}

Console.WriteLine("Thank you for shopping cars with us today! Bye bye");