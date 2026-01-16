Console.Write("Enter a choice between 1 - 4: ");
int choice = int.Parse(Console.ReadLine());

switch(choice)
{
    case 1: 
        Console.WriteLine("You chose 1");
        break;

    case 2:
        Console.WriteLine("You chose 2");
        break;

    // Do not use break, this will declare a fall through OR
    case 3:
    case 4:
        Console.WriteLine("You chose 3 or 4");
        break;        

    default:
        Console.WriteLine("Sorry, that's not a choice");
        break;
}

if(choice == 1) 
    Console.WriteLine("You chose 1");
else if(choice == 2)
    Console.WriteLine("You chose 2");
else if(choice == 3 || choice == 4)
    Console.WriteLine("You chose 3 or 4");
else
    Console.WriteLine("Sorry, that's not a choice");
