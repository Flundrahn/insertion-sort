``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19043.2006/21H1/May2021Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.401
  [Host]     : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2


```
|                  Method |       Mean |    Error |   StdDev |
|------------------------ |-----------:|---------:|---------:|
|           CountFredSort |   437.9 ms |  8.71 ms |  9.68 ms |
| CountFredSortSimplified |   431.6 ms |  5.17 ms |  4.31 ms |
|      CountInsertionSort | 3,054.7 ms | 18.77 ms | 15.67 ms |
