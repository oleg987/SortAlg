namespace SortAlghoritms;

public static class SortHelpers
{
    public static void Swap(int[] array, int leftIndex, int rightIndex)
    {
        int temp = array[leftIndex];
        array[leftIndex] = array[rightIndex];
        array[rightIndex] = temp;
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