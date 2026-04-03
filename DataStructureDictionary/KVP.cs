public class KVP<TKey, TValue> : IKVP<TKey, TValue>
{
    public TKey Key { get; private set; }

    public TValue Value { get; private set; }

    public KVP(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }

    public override string ToString()
    {
        return $"{Key}:{Value}";
    }
}