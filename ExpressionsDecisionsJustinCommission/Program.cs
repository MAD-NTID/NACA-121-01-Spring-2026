/*
Problem Statement:
Justin works at a car dealership.  He gets a commission on his car sales.
What we need is a tool to help us calculate Justin’s commission.
Justin gets a 7% commission of the total sale
Justin only gets the commission if the sale is $10,000 or more
Examples:
If Justin sells a car for $15,000 his commission is $1,050
If Justin sells a car for $7,000 his commission is $0
*/
const int COMMISSION_LIMIT = 10000;
const double COMMISION_PERCENTAGE = .07; // 7%

Console.Write("Enter the car sale price: ");
double salePrice = double.Parse(Console.ReadLine());

if (salePrice >= COMMISSION_LIMIT)
{
    // Show the output as currency with two decimal places
    Console.WriteLine($"{salePrice * COMMISION_PERCENTAGE:C}");
}
else
{
    Console.WriteLine("Poor Justin gets no commission");
}