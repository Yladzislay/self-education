using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class StringConcatenationBenchmark
{
    private const int NumberOfRuns = 10000;

    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<StringConcatenationBenchmark>();
    }

[Benchmark]
    public string StringConcatenationUsingStringBuilder()
        {
            StringBuilder stringBuilder = new();
            for (int i = 0; i < NumberOfRuns; i++)
            {
                stringBuilder.AppendLine("Hello World" + i);
            }
            return stringBuilder.ToString();
        }

[Benchmark]
    public string StringConcatenationUsingString()
        {
            string str = string.Empty;
            for (int i = 0; i < NumberOfRuns; i++)
            {
                str += "Hello World" + i;
            }
            return str;
        }
}