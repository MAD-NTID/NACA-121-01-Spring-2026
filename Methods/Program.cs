void MyFirstMethod()
{
    Console.WriteLine("Hello, this is my first method");
}

void PrintMyName(string name)
{
    Console.WriteLine($"Hello, your name is {name}");
}

// Method Invocation
MyFirstMethod();

// Method Invocation with Parameters
PrintMyName("Aidan");
PrintMyName("Shamik");
PrintMyName("Shashank");
PrintMyName("Nathan Meyer");
PrintMyName("Abhik");
PrintMyName("Nathan Facey");
PrintMyName("Ahmed");
PrintMyName("Dalton");

// Do not include last name
optionalParameter("Michael");
optionalParameter("Michael", "Berrios");

// Optional parameters always goes last. Required are always first.
void optionalParameter(string firstName, string lastName = "Optional")
{
    Console.WriteLine($"{firstName} {lastName}");
}