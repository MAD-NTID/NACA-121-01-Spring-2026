using System.Text;

public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
{
    // 70% Load Factor before Dictionary Grows
    const double LOAD_FACTOR = .7;

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
        Count = 0;
    }

    public void Add(TKey key, TValue value)
    {
        EnsureCapacity();

        if(!ContainsKey(key))
            throw new Exception("Cannot contain duplicate key");

        // Get the hashed index of the key
        int indexLocation = LinearProbing(key);

        if(indexLocation == -1)
            throw new ArgumentException("No available location!");

        items[indexLocation] = new KVP<TKey, TValue>(key, value);

        Count ++;
    }

    public void Clear()
    {
        items = new IKVP<TKey, TValue>[Capacity];
        Count = 0;
    }

    public bool ContainsKey(TKey key)
    {
        // Get the hashed index of the key
        int indexLocation = LinearProbing(key);

        // Returns whether we have the key or not
        return indexLocation >= 0;
    }

    public bool ContainsValue(TValue value)
    {
        // Iterate each of the KVP in items
        foreach(IKVP<TKey, TValue> kvp in items)
        {
            /*
                1. Check kvp is not null &&
                2. Check that kvp.Value equals to value from parameter
            */
            if(kvp is not null && EqualityComparer<TValue>.Default.Equals(kvp.Value, value))
                return true;
        }

        // Does not exist
        return false;
    }

    public IKVP<TKey, TValue> Get(TKey key)
    {
        if(!ContainsKey(key))
            throw new Exception($"Key: {key} does not exist");

        int indexLocation = LinearProbing(key);

        return items[indexLocation];
    }

    public int GetIndex(TKey key)
    {
        int indexLocation = Math.Abs(key.GetHashCode() % Capacity);

        return indexLocation;
    }

    public bool Remove(TKey key)
    {
        if(!ContainsKey(key))
            return false;

        int indexLocation = LinearProbing(key);

        items[indexLocation] = null;
        Count --;

        return true;
    }

    private int LinearProbing(TKey key, bool searchExistingKey = false)
    {
        // Get the indexLocation of the collided key
        int indexLocation = GetIndex(key);

        // We need an index to begin probing
        // Make it the same as the collided indexLocation
        int probingIndex = indexLocation;

        // Begin Probing
        do
        {
            // Get the KVP at the current index
            IKVP<TKey, TValue> kvp = items[probingIndex];

            // If searching existing key, simply return the spot (since it's the same key, likely the same KVP (update))
            if(searchExistingKey && kvp != null && EqualityComparer<TKey>.Default.Equals(kvp.Key, key))
            {
                return probingIndex;
            }

            // if KVP is null, then this is an open spot
            else if (!searchExistingKey && kvp == null)
            {
                return probingIndex;
            }

            // Move to the next index, wrapping around if necessary
            probingIndex = (probingIndex + 1) % Capacity;
        } while (probingIndex != indexLocation);

        // Entire Array is Probed and Found no Suitable Spot for the new KVP
        return -1;
    }

    private void EnsureCapacity()
    {
        double loadFactor = Count / Capacity;

        // Expand the Dictionary
        if(loadFactor >= LOAD_FACTOR)
        {
            // Increase the Capacity by double
            Capacity *= 2;

            // Temporary reconstruction of the new items hashtable
            IKVP<TKey, TValue>[] hashtable = new IKVP<TKey, TValue>[Capacity];

            // Make a copy of the old items
            IKVP<TKey, TValue>[] oldItems = items;

            items = hashtable;  //  Temporarily points to the new array

            // Rehash New Elements
            foreach(IKVP<TKey, TValue> kvp in oldItems)
            {
                if(kvp != null)
                {
                    int indexLocation = LinearProbing(kvp.Key);

                    items[indexLocation] = kvp;
                }
            }
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new("Items:\n");

        foreach(IKVP<TKey, TValue> kvp in items)
        {
            if(kvp is not null)
                sb.AppendLine(kvp.ToString());
        }

        return sb.ToString();
    }
}