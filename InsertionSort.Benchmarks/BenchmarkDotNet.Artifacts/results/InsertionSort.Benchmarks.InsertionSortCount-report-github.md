``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19043.2006/21H1/May2021Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.401
  [Host]     : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  Job-OGFKHH : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=3  WarmupCount=3  

```
|             Method |     Mean |    Error |  StdDev |
|------------------- |---------:|---------:|--------:|
|      CountFredSort | 435.6 ms | 10.56 ms | 6.28 ms |
| CountFredSortArray | 433.5 ms | 12.83 ms | 7.63 ms |
