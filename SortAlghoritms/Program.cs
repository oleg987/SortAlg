using SortAlghoritms.DataStructures.LinkedLists;

namespace SortAlghoritms;

class Program
{
    public static void Main(string[] args)
    {
        var d = new Dictionary<int, int>();

        d[1] = 1;
        d[1] = 2;
        
        var list = new LinkedList();
        
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Insert(1, 4);
        list.Insert(0, 0);
        list.Insert(100,5);
    }

    public static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}