using BenchmarkDotNet.Running;

namespace Benchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benchmark");
            BenchmarkRunner.Run<BenchmarkLib>();
        }
    }
}
