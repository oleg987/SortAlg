namespace SortAlghoritms;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*--------*");
        int[] array = { 789, 987, 456, 654, 0, 123, 321, 79, 56, 12, 3, 0 };
        
        PrintArray(array);
        
        Console.WriteLine("*--------*");
        RadixSort.Sort(array);
        
        PrintArray(array);
    }

    public static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}