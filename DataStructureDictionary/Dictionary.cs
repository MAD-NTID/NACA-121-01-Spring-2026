public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
{
    // Keep count of actual KVP's in the dictionary
    public int Count { get; private set; }

    // The capacity holds the size of the array
    public int Capacity { get; private set; }

    // Default Capacity if not provided
    const int CAPACITY = 5;

    // The Array of KVP (array of KVP)
    private IKVP<TKey, TValue>[] items;

    public Dictionary(int capacity = CAPACITY)
    {
        // Update Capacity with constructor's capacity
        Capacity = capacity;

        // Initialize the array of KVP with size Capacity
        items = new IKVP<TKey, TValue>[Capacity];
    }

    public void Add(TKey key, TValue value)
    {
        int indexLocation = Math.Abs(key.GetHashCode() % Capacity);

        items[indexLocation] = new KVP<TKey, TValue>(key, value);
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool ContainsKey(TKey key)
    {
        throw new NotImplementedException();
    }

    public bool ContainsValue(TValue value)
    {
        throw new NotImplementedException();
    }

    public IKVP<TKey, TValue> Get(TKey key)
    {
        int indexLocation = Math.Abs(key.GetHashCode() % Capacity);

        return items[indexLocation];
    }

    public int GetIndex(TKey key)
    {
        throw new NotImplementedException();
    }

    public bool Remove(TKey key)
    {
        throw new NotImplementedException();
    }
}