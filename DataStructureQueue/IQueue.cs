public interface IQueue<T>
{
    public int Count { get; }
    public bool Contains(T element);
    public T Dequeue();
    public void Enqueue(T element);
    public T[] ToArray();
    public void Clear();
    public T Peek();
}