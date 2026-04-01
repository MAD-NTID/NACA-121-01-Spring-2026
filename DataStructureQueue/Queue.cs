using System.Collections;

public class Queue<T> : IQueue<T>, IEnumerable<T>
{
    private Node<T>? front, back;

    public int Count { get; private set; }

    public Queue()
    {
        front = null;
        back = null;
        Count = 0;
    }

    public void Clear()
    {
        // Clearing the Queue is the same as the constructor
        front = null;
        back = null;
        Count = 0;
    }

    public bool Contains(T element)
    {
        if(front is null)
            return false;

        Node<T>? current = front;
        while(current is not null)
        {
            if(EqualityComparer<T>.Default.Equals(element, current.Data))
                return true;

            current = current.Next;
        }

        return false;
    }

    public T? Dequeue()
    {
        if(front is null)
            return default;

        // Get the data from the front (current front)
        T? data = front.Data;

        // Update the new front with the one behind the current front
        front = front.Next;

        Count --;

        // Special Edge Case - if the front is null, then the back must also be null
        // Indicating that the queue is empty (line is empty)
        if(front is null)
            back = null;

        // Finally, return the data that was dequeued from the queue
        return data;
    }

    public void Enqueue(T element)
    {
        Node<T> enqueueNode = new Node<T>(element);
        Count ++;

        // If there's nothing in the queue
        if(front is null)
        {
            // Set both the front and back to the new node
            // This is because if the Queue is empty, a new Node becomes 
            // both the front and back simultaneously
            // Example: you are the only in the line
            front = back = enqueueNode;

            return;
        }

        // Otherwise, add to the back of the queue (back of the line)
        // First, tell the back Node that you have some new node added to the back
        back.Next = enqueueNode;

        // Then, update the back node with the updated Node. This becomes the new
        // back Node.
        back = enqueueNode;
    }

    public T? Peek()
    {
        if(front.Data is not null)
            return front.Data;

        return default;
    }

    public T[] ToArray()
    {
        // Convert the queue to an array
        T[] elements = new T[Count];
        Node<T>? current = front;
        int index = 0;

        while(current is not null)
        {
            elements[index ++] = current.Data;
            
            current = current.Next;
        }

        return elements;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T>? current = front;
        while(current is not null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        if(front is null)
            return "null";

        return front.ToString();
    }
}