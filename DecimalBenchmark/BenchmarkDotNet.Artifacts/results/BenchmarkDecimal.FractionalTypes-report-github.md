``` ini

BenchmarkDotNet=v0.12.0, OS=ubuntu 20.04
Intel Core i7-10875H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=6.0.100-preview.4.21255.9
  [Host]   : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT
  ShortRun : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |      Mean |     Error |    StdDev |
|---------------- |----------:|----------:|----------:|
|      DecimalAdd | 8.2118 ns | 0.0381 ns | 0.0021 ns |
| DecimalMultiply | 8.2124 ns | 0.0612 ns | 0.0034 ns |
|   DecimalDivide | 7.9849 ns | 0.0142 ns | 0.0008 ns |
|       DoubleAdd | 0.0000 ns | 0.0000 ns | 0.0000 ns |
|  DoubleMultiply | 0.0000 ns | 0.0000 ns | 0.0000 ns |
|    DoubleDivide | 0.0000 ns | 0.0000 ns | 0.0000 ns |
|       SingleAdd | 0.0000 ns | 0.0000 ns | 0.0000 ns |
|  SingleMultiply | 0.0000 ns | 0.0000 ns | 0.0000 ns |
|    SingleDivide | 0.0000 ns | 0.0000 ns | 0.0000 ns |
