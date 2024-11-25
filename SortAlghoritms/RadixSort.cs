using System.ComponentModel.DataAnnotations;

namespace SortAlghoritms;

public static class RadixSort
{
    public static void Sort(int[] array)
    {
        List<Queue<int>> buckets = new List<Queue<int>>();

        for (int i = 0; i < 10; i++)
        {
            buckets.Add(new());
        }

        int maxLength = MaxLength(array);

        for (int step = 0; step <= maxLength; step++)
        {
            foreach (int value in array)
            {
                int index = value / (int)Math.Pow(10, step) % 10;
                buckets[index].Enqueue(value);
            }
        
            int arrayIndex = 0;
            foreach (Queue<int> bucket in buckets)
            {
                while (bucket.TryDequeue(out int value))
                {
                    array[arrayIndex++] = value;
                }
            }
        }
    }

    private static int MaxLength(int[] array)
    {
        int maxLength = 0;

        foreach (var value in array)
        {
            int currentLength = value == 0 ? 1 : (int)Math.Log10(value);

            if (maxLength < currentLength)
            {
                maxLength = currentLength;
            }
        }

        return maxLength;
    }
}