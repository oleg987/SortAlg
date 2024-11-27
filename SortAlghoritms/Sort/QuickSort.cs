namespace SortAlghoritms.Sort;

/*
 * Pivot element can be:
 * 1. First
 * 2. Last +
 * 3. Random +
 * 4. Other =)
 */
public static class QuickSort
{
    public static void Sort(int[] array)
    {
        Sort(array, 0, array.Length - 1);
    }

    private static void Sort(int[] array, int leftPointer, int rightPointer)
    {
        if (leftPointer < rightPointer)
        {
            int pivot = RandomPartition(array, leftPointer, rightPointer);
            
            Sort(array, leftPointer, pivot - 1);
            Sort(array, pivot + 1, rightPointer);
        }
    }
    
    private static int RandomPartition(int[] array, int leftPointer, int rightPointer)
    {
        int randomIndex = Random.Shared.Next(leftPointer, rightPointer + 1);
        
        SortHelpers.Swap(array, randomIndex, rightPointer);
        
        return Partition(array, leftPointer, rightPointer);
    }
    
    private static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                SortHelpers.Swap(array, i, j);
            }
        }

        SortHelpers.Swap(array, i + 1, right);
        return i + 1;
    }
}