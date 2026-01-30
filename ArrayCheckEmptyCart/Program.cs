string[] itemName = new string[10];
double[] itemPrice = new double[10];

itemName[0] = "sweater";
itemPrice[0] = 19.99;

itemName[3] = "socks";
itemPrice[3] = 9.99;

// How to calculate total of spaces filled in array
int itemCounts = 0;
double itemsPrices = 0;
for(int i = 0; i < itemName.Length; i++)
{
    // check if item exists in i (current index)
    if(!string.IsNullOrEmpty(itemName[i]))
    {
        itemCounts++;
        itemsPrices += itemPrice[i];   
    }
}

Console.WriteLine($"Total Number of Items {itemCounts}\nTotal Price: {itemsPrices:c}");