namespace SortAlghoritms.Sort;

public class BubbleSort
{
    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (SortHelpers.IsGreater(array[i], array[j]))
                {
                    SortHelpers.Swap(array, i, j);
                }
            }
        }
    }
}