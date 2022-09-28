``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19043.2006/21H1/May2021Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.401
  [Host]     : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  Job-IODRRF : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=3  WarmupCount=3  

```
|                  Method |       Mean |     Error |   StdDev |
|------------------------ |-----------:|----------:|---------:|
|           CountFredSort |   427.2 ms |   7.01 ms |  4.17 ms |
| CountFredSortSimplified |         NA |        NA |       NA |
|      CountInsertionSort | 3,065.8 ms | 123.73 ms | 73.63 ms |

Benchmarks with issues:
  InsertionSortCount.CountFredSortSimplified: Job-IODRRF(IterationCount=3, LaunchCount=3, WarmupCount=3)
