using BenchmarkDotNet.Running;
using CommandLine;
using InsertionSort.Benchmarks;

var summary = BenchmarkRunner.Run<InsertionSortCount>();

// 28/9/2022
// |                  Method |       Mean |    Error |   StdDev |
// |------------------------ |-----------:|---------:|---------:|
// |           CountFredSort |   437.9 ms |  8.71 ms |  9.68 ms |
// | CountFredSortSimplified |   431.6 ms |  5.17 ms |  4.31 ms |
// |      CountInsertionSort | 3,054.7 ms | 18.77 ms | 15.67 ms |