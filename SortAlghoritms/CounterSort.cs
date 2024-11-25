namespace SortAlghoritms;

public static class CounterSort
{
    public static void Sort(int[] array)
    {
        int[] counters = new int[10];

        for (int i = 0; i < array.Length; i++)
        {
            counters[array[i]]++;
        }

        int index = 0;

        for (int i = 0; i < counters.Length; i++)
        {
            for (int j = 0; j < counters[i]; j++)
            {
                array[index++] = i;
            }
        }
    }
}