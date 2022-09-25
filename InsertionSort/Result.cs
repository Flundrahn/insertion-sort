public static class Result
{
    public static (int, int[]) insertionSort(int[] arr)
    {
        int numberOfMoves = 0;
        IEnumerable<int> sorted = arr.Take(1);

        for (var i = 1; i < arr.Length; i++)
        {
            var current = arr[i];
            // NOTE This may be unlikely enough that it does not pay off to add one extra if here, one extra if for each number
            if (current >= sorted.ElementAt(i - 1))
            {
                sorted = sorted.Concat(new int[] { current });
                continue;
            }

            var upperIndex = i;
            var middleIndex = i / 2;
            var lowerIndex = 0;

            while (upperIndex - lowerIndex > 0)
            {
                if (current < sorted.ElementAt(middleIndex)) // NOTE Consider using List<int> instead
                {
                    upperIndex = middleIndex;
                }
                else if (current > sorted.ElementAt(middleIndex))
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
            // NOTE Previously also had this && (middleIndex + 1) != i which should never happen since everything is sorted by size, and in beginning of algorithm the leftmost element is checked. Keep out unless remove first check.
            while (current == sorted.ElementAt(middleIndex))
            {
                middleIndex += 1;
            }

            sorted = sorted.Take(middleIndex)
                .Concat(new int[] { current })
                .Concat(sorted
                    .Skip(middleIndex)
                    .Take(i - middleIndex));

            numberOfMoves += i - middleIndex;
        }
        return (numberOfMoves, sorted.ToArray());
    }

    // 2 1 3 1 2
    // 1 2 3 1 2 --> (1 - 0) = 1 move
    // 1 2 3 1 2 --> (2 - 2) = 0 move
    // 1 1 2 3 2 --> (3 - 1) = 2 move

    // public static int insertionSort(int[] arr)
    // {
    //     int numberOfMoves = 0;
    //     for (var i = 1; i < arr.Length; i++)
    //     {
    //         var currentInteger = arr[i];
    //         var j = i - 1;
    //         while (j >= 0 && arr[j] > currentInteger)
    //         {
    //             arr[j + 1] = arr[j];
    //             j--;
    //         }
    //         arr[j + 1] = currentInteger;
    //         numberOfMoves += i - (j + 1);
    //     }
    //     return numberOfMoves;
    // }

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

