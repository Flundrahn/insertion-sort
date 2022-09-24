public static class Result
{
    // NOTE Returns number of moves
    public static int insertionSort(int[] arr)
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

    // NOTE Returns sorted array
    public static int[] DoInsertionSort(int[] arr)
    {
        for (var i = 1; i < arr.Length; i++)
        {
            var currentInteger = arr[i];
            // var flag = 0;
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

    // NOTE Returns sorted array
    public static int[] DoFredSort(int[] arr)
    {
        // IEnumerable<int> newLeftArray = null;
        var newLeftArray = new int[] { };

        for (var i = 1; i < arr.Length; i++)
        {
            var current = arr[i];

            var upperIndex = i;
            var middleIndex = i / 2;
            var lowerIndex = 0;

        }
    // NOTE the range operator does not include last indice.
    
        return newLeftArray;
    }

    // while (middleIndex > lowerIndex)
    //         {
    //             middleIndex = (upperIndex + lowerIndex) / 2;

    //             if (arr[middleIndex] > current)
    //             {
    //                 upperIndex = middleIndex;
    //             }
    //             else if (arr[middleIndex] < current)
    //             {
    //                 lowerIndex = middleIndex;
    //             }
    //             else if (arr[middleIndex] == current)
    //             {
    //                 // found exactly equal, place there
    //             }
    //         }

    //         if (middleIndex == 0)
    //         {
    //             if (arr[middleIndex] > current)
    //             {
    //                 newLeftArray = new int[] {current}
    //                     .Concat(newLeftArray[middleIndex..upperIndex])
    //                     .ToArray();
    //             }
    //             else
    //             {
    //                 newLeftArray = newLeftArray[0..middleIndex]
    //                     .Concat(new int[] {current})
    //                     .Concat(newLeftArray[middleIndex..])
    //                     .ToArray();
    //             }
    //         }
    //         // 
    //         newLeftArray = arr[0..middleIndex]
    //             .Concat(new int[] { current })
    //             .Concat(arr[(middleIndex + 1)..])
    //             .ToArray();
    //     }

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

