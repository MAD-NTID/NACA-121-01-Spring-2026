string name = "Michael";
int age = 18;
double money = 2000.54;

// Interpolation using replacement values
Console.WriteLine("Hello, my name is {0}. I am {1} years old. And I have ${2} in my account", name, age, money);

// String Interpolation using inplace values
Console.WriteLine($"Hello, my name is {name}. I am {age} years old. And I have ${money} in my account");