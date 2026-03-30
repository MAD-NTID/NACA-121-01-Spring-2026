using System.Collections;

public class Stack<T> : IStack<T>, IEnumerable<T>
{
    /*
        Keeps the count increment and decrement of the stack internal
        But allow access to the count
    */
    public int Count { get; private set; }
    
    /*
        Top indicates the Node at the top of the stack
        Important for Stack Data Structure
        ? > allows nullable Node<T>
    */
    public Node<T>? Top { get; private set; }

    public Stack()
    {
        Count = 0;
        Top = null;
    }

    public void Clear()
    {
        Count = 0;
        Top = null;
    }

    public bool Contains(T element)
    {
        if(Top is null)
            return false;

        // Make a copy of the top
        Node<T>? copyOfTop = Top;
        
        // We will "traverse" the copy of Top and go through each of its Next Node
        // and compare that Node with the T value we're seeking for
        while(copyOfTop is not null)
        {
            if(EqualityComparer<T>.Default.Equals(copyOfTop.Data, element))
                // means we found a match and return true
                return true;

            // means we did not find a match, so move on to the next Node
            copyOfTop = copyOfTop.Next;
        }

        // Lastly, a match could not be found
        return false;
    }

    public T? Peek()
    {
        // Returns the Data of the Top Node
        return Top.Data;
    }

    public T? Pop()
    {
        // First get the data at the top
        T? currentTopData = Top.Data;

        // Replace Top with the current Top's Next Node
        Top = Top.Next;

        // Decrement the count
        Count --;

        return currentTopData;
    }

    public void Push(T element)
    {
        // node in the parameter is to become the new top
        // first, we need to know who the current top is
        Node<T>? currentTop = Top;

        /*
            This is where the magic happens.
            We create a new Node and make it the Top
            Also, make the previous Top the new Node's Next Node
        */
        Node<T>? newNode = new Node<T>(element, currentTop);

        // Replace Top with the new Node
        Top = newNode;

        // Increment the count of the stack
        Count ++;
    }

    public T?[] ToArray()
    {
        // Create an Array of T with the Count in the stack
        T?[] toArray = new T[Count];
        
        // Next, we insert the values of the stack to the array
        Node<T>? copyOfTop = Top;
        int pointer = 0; 

        while(copyOfTop is not null)
        {
            toArray[pointer ++] = copyOfTop.Data;

            copyOfTop = copyOfTop.Next;
        }

        return toArray;
    }

    public IEnumerator<T> GetEnumerator()
    {
        /*
            Before we can use the Enumerator, we need to teach C# how to enumerate
            through our Stack
        */
        Node<T>? currentTop = Top;
        while(currentTop is not null)
        {
            yield return currentTop.Data;
            currentTop = currentTop.Next;
        }
    }

    // You do not need to touch this one
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        if(Top is null)
            return "null";

        return Top.ToString();
    }
}