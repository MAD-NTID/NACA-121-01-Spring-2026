using Newtonsoft.Json;

// // Basic Example
// Card oneOfSpadeRed = new("Spade", "Red", 1);

// Console.WriteLine(oneOfSpadeRed);
// Console.WriteLine();

// string serialized = JsonConvert.SerializeObject(oneOfSpadeRed);

// Console.WriteLine(serialized);

// Card? deserializedCard = JsonConvert.DeserializeObject<Card>(serialized);

// Console.WriteLine($"Deserialized: \n{deserializedCard}");

// Createa  Deck of 52 Cards
Card[] deck = new Card[54];
int index = 0;

string[] suits = { "Spade", "Diamond", "Hearts", "Club" };
int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

foreach (string suit in suits)
{
    string color = (suit == "Hearts" || suit == "Diamond") ? "Red" : "Black";

    foreach (int value in values)
    {
        deck[index++] = new Card(suit, color, value);
    }
}

// Add the Jokers
deck[index++] = new Card("Joker", "Black", 0);
deck[index++] = new Card("Joker", "Red", 0);

// Convert the Deck to JSON
string serializedDeck = JsonConvert.SerializeObject(deck);
Console.WriteLine(serializedDeck);

StreamWriter sw = new StreamWriter("deck.json");
sw.Write(serializedDeck);
sw.Close();

// Read from file and convert back to object
StreamReader sr = new StreamReader("deck.json");
// Now that we have the string, we begin deserialization
string deckJsonString = sr.ReadToEnd();
// We deserialize back to an array of Card
Card[] deck2 = JsonConvert.DeserializeObject<Card[]>(deckJsonString);

for(int i = 0; i < deck.Length; i++)
{
    Console.WriteLine($"{i} - Deck 1 {deck[i]} | Deck 2 {deck2[i]}");
}