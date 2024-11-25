namespace SortAlghoritms;

public static class InsertSort
{
    public static void Sort(int[] array)
    {
        if (array.Length <= 1)
        {
            return;
        }
        
        for (int i = 1; i < array.Length; i++)
        {
            int temp = array[i];

            int j = i;

            while (j > 0 && SortHelpers.IsLess(temp, array[j - 1]))
            {
                array[j] = array[j - 1];
                j--;
            }

            array[j] = temp;
        }
    }
}