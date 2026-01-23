// Create an array that stores favorite numbers for 8 students

// declare and initialize an int array with 8 elements
int[] favoriteNumbers = new int[8];

// Ahmed
favoriteNumbers[0] = 66;
// Aidan
favoriteNumbers[1] = 18;
// Shashank
favoriteNumbers[2] = 17;
// Shamik
favoriteNumbers[3] = 17;
// Nathan M
favoriteNumbers[4] = 7;
// Dalton
favoriteNumbers[5] = 26;
// Nathan F
favoriteNumbers[6] = 48;
// Abhik
favoriteNumbers[7] = 5;

// System.Int32[] - this means "array of int"
// Console.WriteLine(favoriteNumbers);

for(int i = 0; i < favoriteNumbers.Length; i++)
{
    Console.Write($"{favoriteNumbers[i]} ");
}

Console.WriteLine();

// We can update values after assigning them
favoriteNumbers[7] = 55;

for(int i = 0; i < favoriteNumbers.Length; i++)
{
    Console.Write($"{favoriteNumbers[i]} ");
}