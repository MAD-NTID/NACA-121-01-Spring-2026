public interface IKVP<TKey, TValue>
{
    public TKey Key { get; }
    public TValue Value { get; }
}