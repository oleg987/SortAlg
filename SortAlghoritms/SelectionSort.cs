namespace SortAlghoritms;

public static class SelectionSort
{
    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minIndex = i;
            for (int j = i; j < array.Length; j++)
            {
                if (SortHelpers.IsGreater(array[minIndex], array[j]))
                {
                    minIndex = j;
                }
            }

            if (i != minIndex)
            {
                SortHelpers.Swap(array, i, minIndex);
            }
        }
    }
}