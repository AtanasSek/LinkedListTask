// See https://aka.ms/new-console-template for more information

TaskList<int> list = new TaskList<int>();

list.AddFirst(1);
list.AddFirst(2);
list.AddFirst(3);
list.AddFirst(4);
list.AddFirst(5);

list.PrintElements();

class Node<T>
{
    public T element;
    public Node<T> next,prev;
    
    public Node(T element, Node <T> prev, Node <T> next)
    {
        this.element = element;
        this.prev = prev;
        this.next = next;
    }

    public String ToString()
    {
        return element.ToString();
    }

}

class TaskList<T>
{
    private Node<T> first,last;
    

    public TaskList()
    {

    }

    public void AddFirst(T element)
    {
        Node<T> node = new Node<T>(element,null,first);

        if(first == null)
        { 
            last = node;
        }
        else
        {
            first.prev = node;
        }
        
        first = node;
    }

    public void AddLast(T element)
    {
        Node<T> node = new Node<T>(element, last , null);

        if (last == null)
        {
            first = node;
        }
        else
        {
            last.next = node;
        }
        last = node;
    }

    public void RemoveFirst()
    {
        if (first != null)
        {
            first = first.next;
            first.prev = null;        
        }     
    }

    public void RemoveLast()
    {
        if(last != null)
        {
            last = last.prev;
            last.next = null;
        }
    }


    //Otstrani go prviot element koj sto ja sodrzi taa vrednost
    public void Remove(T item)
    {
        Node<T> node = first;

        while(node != null)
        {

            if(node.element.Equals(item))
            {
                if(node.next !=null)
                    node.next.prev = node.prev;
                if (node.prev != null)
                    node.prev.next = node.next;
                break;
            }

            node = node.next;

        }
    }

    public void PrintElements()
    {
        Node<T> node = first;
        while(node != null)
        {
            Console.WriteLine(node.ToString());
            
            node = node.next;
        }
        
    }
}

