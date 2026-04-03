public interface IDictionary<TKey, TValue>
{
    // Returns the number of KVP elements in the dictionary
    public int Count { get; }

    // Stores the capacity of the dictionary
    public int Capacity { get; }

    // Clear (removes) all the KVP elements in the dictionary
    public void Clear();

    // Returns boolean if a key exists in the dictionary
    public Boolean ContainsKey(TKey key);

    // Returns boolean if a value exists in the dictionary
    public Boolean ContainsValue(TValue value);

    // Add a new KVP to the dictionary
    public void Add(TKey key, TValue value);

    // Remove a KVP from the dictionary by its key
    public bool Remove(TKey key);

    // Get the index position in the array of the dictionary by its key
    public int GetIndex(TKey key);

    // Returns the KVP object itself by its key
    public IKVP<TKey, TValue> Get(TKey key);
}