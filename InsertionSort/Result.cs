public static class Result
{
    public static (int, int[]) CountFiddyFiddySort(int[] arr)
    {
        int numberOfMoves = 0;
        var sorted = new int[arr.Length];
        sorted[0] = arr[0];

        for (var i = 1; i < arr.Length; i++)
        {
            var current = arr[i];

            if (current >= sorted[i - 1])
            {
                sorted[i] = current;
                continue;
            }

            var upperIndex = i;
            var index = i / 2;
            var lowerIndex = 0;

            while (upperIndex - lowerIndex > 0)
            {
                if (current < sorted[index]) upperIndex = index;
                else if (current > sorted[index]) lowerIndex = index + 1;
                else goto insert;

                index = (upperIndex + lowerIndex) / 2;
            }

        insert:
            while (current == sorted[index])
            {
                index += 1;
            }

            sorted.Insert(index, current, i - index);
            numberOfMoves += i - index;
        }
        return (numberOfMoves, sorted);
    }

    public static void Insert(this int[] arr, int index, int value, int elementsToShift)
    {
        Buffer.BlockCopy(
            arr,
            sizeof(int) * index,
            arr,
            sizeof(int) * (index + 1),
            sizeof(int) * elementsToShift
        );
        arr[index] = value;
    }

    public static (int, int[]) CountInsertionSort(int[] arr)
    {
        int numberOfMoves = 0;
        for (var i = 1; i < arr.Length; i++)
        {
            var currentInteger = arr[i];
            var j = i - 1;
            while (j >= 0 && arr[j] > currentInteger)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = currentInteger;
            numberOfMoves += i - (j + 1);
        }
        return (numberOfMoves, arr);
    }
}

