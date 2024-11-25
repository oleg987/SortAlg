namespace SortAlghoritms;

public static class GnomeSort
{
    public static void Sort(int[] array)
    {
        if (array.Length <= 1)
        {
            return;
        }

        int counter = 1;

        while (counter < array.Length)
        {
            if (counter == 0 || SortHelpers.IsGreaterOrEqual(array[counter], array[counter - 1]))
            {
                counter++;
            }
            else
            {
                SortHelpers.Swap(array, counter, counter - 1);
                counter--;
            }
        }
    }
}