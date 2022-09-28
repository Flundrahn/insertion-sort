namespace InsertionSort;

public static class Result
{
    public static int CountFredSort(int[] arr)
    {
        int numberOfMoves = 0;
        List<int> sorted = new List<int>(arr.Length);
        sorted.Add(arr[0]);

        for (var i = 1; i < arr.Length; i++)
        {
            var current = arr[i];
            var upperIndex = i;
            var middleIndex = i / 2;
            var lowerIndex = 0;

            while (upperIndex - lowerIndex > 0)
            {
                if (current < sorted[middleIndex]) upperIndex = middleIndex; // lower half
                else if (current > sorted[middleIndex]) lowerIndex = middleIndex + 1; // upper half
                else goto insert;

                middleIndex = (upperIndex + lowerIndex) / 2;
            }

        insert:
            while (middleIndex < i && current == sorted[middleIndex])
            {
                middleIndex += 1;
            }

            sorted.Insert(middleIndex, current);
            numberOfMoves += i - middleIndex;
        }
        return numberOfMoves;
    }

    public static int CountInsertionSort(int[] arr)
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
        return numberOfMoves;
    }

    public static int[] DoInsertionSort(int[] arr)
    {
        for (var i = 1; i < arr.Length; i++)
        {
            var currentInteger = arr[i];

            var j = i - 1;

            while (j >= 0 && arr[j] >= currentInteger)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = currentInteger;
        }

        return arr;
    }

    public static int[] DoFredSort(int[] arr)
    {
        IEnumerable<int> sorted = arr.Take(2);

        for (var i = 1; i < arr.Length; i++)
        {
            var current = arr[i];

            var upperIndex = i;
            var middleIndex = i / 2;
            var lowerIndex = 0;

            while (upperIndex - lowerIndex > 0)
            {
                if (current < arr[middleIndex])
                {
                    upperIndex = middleIndex;
                }
                else if (current > arr[middleIndex])
                {
                    lowerIndex = middleIndex + 1;
                }
                else
                {
                    goto insert;
                }

                middleIndex = (upperIndex + lowerIndex) / 2;
            }

        insert:
            sorted = sorted.Take(middleIndex)
                .Concat(new int[] { current })
                .Concat(sorted
                    .Skip(middleIndex)
                    .Take(i - middleIndex));
        }
        return sorted!.ToArray();
    }

    public static int insertionSortOld(int[] arr)
    {
        int numberOfMoves = 0;
        for (var i = 1; i < arr.Length; i++)
        {
            var currentInteger = arr[i];

            Array.Sort(arr, 0, i + 1);

            numberOfMoves += i - Array.FindLastIndex(arr, i, e => e == currentInteger);
        }

        return numberOfMoves;
    }
}

