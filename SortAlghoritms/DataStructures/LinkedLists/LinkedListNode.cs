namespace SortAlghoritms.DataStructures.LinkedLists;

public class LinkedListNode
{
    public int Value { get; }
    public LinkedListNode? Next { get; set; }

    public LinkedListNode(int value)
    {
        Value = value;
    }
}