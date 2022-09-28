using BenchmarkDotNet.Attributes;

namespace InsertionSort.Benchmarks;

// [SimpleJob(launchCount: 3, warmupCount: 3, targetCount: 3)]
public class InsertionSortCount
{
    private const int n = 100000;
    private const int upperBound = 10000000;

    [Benchmark]
    public int CountFredSort()
    {
        var numberOfMoves = Result.CountFredSort(CreateIntegerArray(n, upperBound));

        return numberOfMoves;
    }

    [Benchmark]
    public int CountInsertionSort()
    {
        var numberOfMoves = Result.CountInsertionSort(CreateIntegerArray(n, upperBound));

        return numberOfMoves;
    }

    private int[] CreateIntegerArray(int length, int upperBound)
    {
        var random = new Random();
        var arr = new int[length];
        for (var i = 0; i < length; i++)
        {
            arr[i] = random.Next(0, upperBound + 1);
        }

        return arr;
    }
}