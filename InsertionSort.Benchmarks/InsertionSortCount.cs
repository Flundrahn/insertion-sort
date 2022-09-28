using BenchmarkDotNet.Attributes;

namespace InsertionSort.Benchmarks;

[SimpleJob(launchCount: 3, warmupCount: 3, targetCount: 3)]
public class InsertionSortCount
{
    private const int n = 100000;
    private const int upperBound = 10000000;
    private int[] _arr;

    public InsertionSortCount()
    {
        _arr = CreateIntegerArray(n, upperBound);
    }

    [Benchmark]
    public int CountInsertionSort()
    {
        var (numberOfMoves, _) = Result.CountInsertionSort(_arr);

        return numberOfMoves;
    }

    [Benchmark]
    public int CountFiddyFiddySort()
    {
        var (numberOfMoves, _) = Result.CountFiddyFiddySort(_arr);

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