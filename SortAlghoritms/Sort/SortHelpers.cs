namespace SortAlghoritms.Sort;

public static class SortHelpers
{
    public static void Swap(int[] array, int leftIndex, int rightIndex)
    {
        (array[leftIndex], array[rightIndex]) = (array[rightIndex], array[leftIndex]);
    }
    
    public static bool IsGreater(int leftValue, int rightValue)
    {
        return leftValue > rightValue;
    }

    public static bool IsGreaterOrEqual(int leftValue, int rightValue)
    {
        return IsGreater(leftValue, rightValue) || leftValue == rightValue;
    }

    public static bool IsLess(int leftValue, int rightValue)
    {
        return leftValue < rightValue;
    }
}