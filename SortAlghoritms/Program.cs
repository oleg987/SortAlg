namespace SortAlghoritms;

class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 2, 1, 8, 3, 5, 9, 1 };
        
        PrintArray(array);

        Console.WriteLine("*--------*");
        InsertSort.Sort(array);
        
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