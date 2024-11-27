namespace SortAlghoritms.Sort;

/*
 * 1. Array based +
 * 2. Pointer based -
 * 3. Span based - 
 */

public static class MergeSort
{
    public static int[] Sort(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int midPoint = array.Length / 2;
        int leftLength = midPoint;
        int rightLength = array.Length - midPoint;

        int[] left = new int[leftLength];
        int[] right = new int[rightLength];
        
        Array.Copy(array, 0, left, 0, leftLength);
        Array.Copy(array, midPoint, right, 0, rightLength);

        return Merge(Sort(left), Sort(right));
    }

    private static int[] Merge(int[] left, int[] right)
    {
        int leftPointer = 0;
        int rightPointer = 0;

        int[] merged = new int[left.Length + right.Length];

        for (int i = 0; i < merged.Length; i++)
        {
            if (IsIndexInRange(leftPointer, left) && IsIndexInRange(rightPointer, right))
            {
                if (SortHelpers.IsGreater(left[leftPointer], right[rightPointer]))
                {
                    merged[i] = right[rightPointer];
                    rightPointer++;
                }
                else
                {
                    merged[i] = left[leftPointer];
                    leftPointer++;
                }
            }
            else if (IsIndexInRange(leftPointer, left))
            {
                merged[i] = left[leftPointer];
                leftPointer++;
            }
            else if (IsIndexInRange(rightPointer, right))
            {
                merged[i] = right[rightPointer];
                rightPointer++;
            }
        }
        
        return merged;
    }

    private static bool IsIndexInRange(int index, int[] array)
    {
        return index < array.Length;
    }
}
