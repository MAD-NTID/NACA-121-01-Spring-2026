Alien talos = new Alien("Talos", 100);
Human shashank = new Human("Shashank", 21);

Console.WriteLine(talos);
Console.WriteLine($"Talks: {talos.Talk()}");
Console.WriteLine($"Run: {talos.Run()}");
Console.WriteLine($"Walk: {talos.Walk()}");

Console.WriteLine();

Console.WriteLine(shashank);
Console.WriteLine($"Talks: {shashank.Talk()}");
Console.WriteLine($"Run: {shashank.Run()}");
Console.WriteLine($"Walk: {shashank.Walk()}");