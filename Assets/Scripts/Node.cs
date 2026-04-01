

//Un Node no necesita derivar de monobehaviour
public class Node<T> 
{
    private T value = default;

    private Node<T> next;

    public Node (T value)
    {
        this.value = value; 
    }
    
    public void SetNext(Node<T> next)
    {
        this.next = next; 
    }
    public T Value => value;
    public Node<T> Next => next;

}
