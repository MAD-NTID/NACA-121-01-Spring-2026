// What is the hash code of a string?
string key = "Nathan";
string value = "Nathan Meyer";
int hashKey = key.GetHashCode();

// Do not let a hash value be negative, use Math.Abs
hashKey = Math.Abs(hashKey);

// Create an array of size 5
string[] data = new string[5];

// Let's hash a key so that it can go inside the array
// Use mod to limit the final results within the length of the array
// This avoids an index out of bound exception
int hashedIndex = hashKey % data.Length;

data[hashedIndex] = value;

// Add another KVP
key = "Michael";
value = "Michael Berrios";
hashKey = key.GetHashCode();
hashKey = Math.Abs(hashKey);
hashedIndex = hashKey % data.Length;
data[hashedIndex] = value;

for(int i = 0; i < data.Length; i++)
    Console.WriteLine($"index{i} has value {data[i]}");