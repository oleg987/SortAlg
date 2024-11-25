namespace SortAlghoritms;

public static class CocktailSort
{
    public static void Sort(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            int swapCount = 0;
            for (int i = left; i < right; i++)
            {
                if (SortHelpers.IsGreater(array[i], array[i + 1]))
                {
                    SortHelpers.Swap(array, i, i + 1);
                    swapCount++;
                }
            }
            right--;
            
            for (int i = right; i > left; i--)
            {
                if (SortHelpers.IsLess(array[i], array[i - 1]))
                {
                    SortHelpers.Swap(array, i, i - 1);
                    swapCount++;
                }
            }
            left++;

            if (swapCount == 0)
            {
                break;
            }
        }
    }
}