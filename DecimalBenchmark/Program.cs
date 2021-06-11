using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace BenchmarkDecimal
{
    // Puzzle: How much faster are double and single then decimal?
    // a) 3 times faster
    // b) 10 times faster
    // c) 40 times faster
    // d) 100 times faster

    // If you do the same 1,000 multiiplication operations for decimal and double
    // the difference in performance will be:
    // a)                      Less than   0.1  ms
    // b) Greater than 0.1 ms, less than   1    ms
    // c) Greater than 1 ms,   less than 100    ms
    // d) Greater than 100 ms, less than 1000   ms

    [ShortRunJob]
    [CsvExporter]
    public class FractionalTypes
    {
        public FractionalTypes()
        {
            singleValue = 42.3f;
            doubleValue = 42.3;
            decimalValue = 42.3m;
        }

        private readonly float singleValue;
        private readonly double doubleValue;
        private readonly decimal decimalValue;

        [Benchmark]
        public decimal DecimalAdd() => decimalValue + decimalValue;

        [Benchmark]
        public decimal DecimalMultiply() => decimalValue + decimalValue;

        [Benchmark]
        public decimal DecimalDivide() => decimalValue + decimalValue;

        [Benchmark]
        public double DoubleAdd() => doubleValue + doubleValue;

        [Benchmark]
        public double DoubleMultiply() => doubleValue * doubleValue;

        [Benchmark]
        public double DoubleDivide() => doubleValue / doubleValue;

        [Benchmark]
        public double SingleAdd() => doubleValue + doubleValue;

        [Benchmark]
        public double SingleMultiply() => doubleValue * doubleValue;

        [Benchmark]
        public double SingleDivide() => doubleValue / doubleValue;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
            Console.WriteLine(summary);
        }
    }
}
