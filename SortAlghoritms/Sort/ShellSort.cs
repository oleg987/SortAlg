namespace SortAlghoritms.Sort;

public static class ShellSort
{
    public static void Sort(int[] array)
    {
        int step = array.Length / 2;

        while (step > 0)
        {
            for (int i = step; i < array.Length; i++)
            {
                int j = i;

                while (j >= step && SortHelpers.IsGreater(array[j - step], array[j]))
                {
                    SortHelpers.Swap(array, j - step, j);
                    j -= step;
                }
            }

            step /= 2; 
        }
    }
}