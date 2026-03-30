public interface IStack<T>
{
    public int Count { get; }

    public bool Contains(T element);
    public void Clear();
    public void Push(T element);
    public T? Peek();
    public T? Pop();
    public T?[] ToArray();
}
