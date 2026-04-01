public class Node<T>
{
    /*
        Allows to store any kind of data
        This is the data about the node itself

        ? > indicates null is accepted
    */
    public T? Data { get; set; }

    /*
        Store the next node's data
        This is the data about the next node
    */
    public Node<T>? Next { get; set; }

    /*
        Accepts the value for the Node itself
        Accepts a Node<T> for the Next Node
    */
    public Node(T? data, Node<T>? next)
    {
        Data = data;
        Next = next;       
    }

    /*
        Overloaded constructor for when you want to make an instance of Node
        without the Next node
    */
    public Node(T data): this(data, null) {}

    public override string ToString()
    {
        // Show only information about itself if Next Node is null
        if(Next is null)
            return $"{Data} --> null";

        // If Next node is not null, show linked nodes
        return $"{Data} --> {Next}";
    }
}