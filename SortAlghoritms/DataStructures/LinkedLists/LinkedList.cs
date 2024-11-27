namespace SortAlghoritms.DataStructures.LinkedLists;

public class LinkedList
{
    public LinkedListNode? Head { get; private set; }
    public int Count { get; private set; } = 0;

    public LinkedList()
    {
        
    }

    public void Add(int value)
    {
        LinkedListNode linkedListNode = new LinkedListNode(value);
        
        if (Head is null)
        {
            Head = linkedListNode;
        }
        else
        {
            LinkedListNode tail = Head;

            while (tail.Next is not null)
            {
                tail = tail.Next;
            }

            tail.Next = linkedListNode;
        }

        Count++;
    }

    public void Insert(int index, int value)
    {
        if (index < 0 || index > Count - 1)
        {
            throw new IndexOutOfRangeException();
        }
        
        if (index == 0 && Head is null)
        {
            Head = new LinkedListNode(value);
        }

        if (index != 0 && Head is null)
        {
            throw new IndexOutOfRangeException();
        }
        
        LinkedListNode node = new LinkedListNode(value);

        if (index == 0 && Head is not null)
        {
            node.Next = Head;
            Head = node;
            Count++;
            return;
        }
        
        int currentPosition = 0;
        LinkedListNode currentNode = Head!;

        while (currentPosition != index - 1 && currentNode.Next is not null)
        {
            currentNode = currentNode.Next;
            currentPosition++;
        }

        LinkedListNode? previousNext = currentNode.Next;

        node.Next = previousNext;

        currentNode.Next = node;

        Count++;
    }

    public void Remove(int index)
    {
        
    }
}