using BenchmarkDotNet.Attributes;
namespace BenchmarkDateConversion;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class DateParserBenchmarks
{
    private const string DateTime = "2023-10-28T22:31:00Z";
    private static readonly DateParser Parser = new DateParser();

    [Benchmark]
    public void GetYearFromDateTime(){
        Parser.GetYearFromDateTime(DateTime);
    }
}
