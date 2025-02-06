using BenchmarkDotNet.Attributes;
using Lib;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    [MemoryDiagnoser]
    public class BenchmarkLib
    {
        private readonly int[] _milionInts;
        private readonly int _k;

        public BenchmarkLib()
        {
            _milionInts = new int[1000000];

            for (int i = 0; i < 1000000; i++)
            {
                _milionInts[i] = (i - 500000) * 2;
            }

            _k = 999996;
        }

        [Benchmark(Baseline = true)]
        public async Task ExistsListAny()
        {
            Answer.ExistsListAny(_milionInts, _k);
        }

        [Benchmark]
        public async Task ExistsBuiltInBinarySearch()
        {
            Answer.ExistsBuiltInBinarySearch(_milionInts, _k);
        }

        [Benchmark]
        public async Task Exists()
        {
            Answer.Exists(_milionInts, _k);
        }

        [Benchmark]
        public async Task ExistsBinarySearchChatGpt()
        {
            Answer.ExistsBinarySearchChatGpt(_milionInts, _k);
        }

        [Benchmark]
        public async Task ExistsBubble()
        {
            Answer.ExistsBubble(_milionInts, _k);
        }
    }
}
