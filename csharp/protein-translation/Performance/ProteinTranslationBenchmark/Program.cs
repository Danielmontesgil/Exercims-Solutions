using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

[MemoryDiagnoser]
public class BenchMe
{
    [Benchmark]
    [Arguments("UGGUGUUAUUAAUGGUUU")]
    [Arguments("UGGUAGUGG")]
    [Arguments("AUGUUUUAA")]
    [Arguments("UGGUAG")]
    public string[] Proteins(string strand)
    {
        int codonCount = 0;
        List<string> proteins = new List<string>();
    
        while (codonCount < strand.Length)
        {
            var temp = codonCount + 3;
            var protein = FindProtein(strand[codonCount..temp]);
            if (protein != "STOP")
            {
                proteins.Add(protein);
                codonCount = temp;
            }
            else
            {
                break;
            }
        }
    
        return proteins.ToArray();
    }
    
    private string FindProtein(string codon)
    {
        switch (codon)
        {
            case "AUG":
                return "Methionine";
            case "UUU":
            case"UUC":
                return "Phenylalanine";
            case "UUA":
            case "UUG":
                return "Leucine";
            case "UCU":
            case "UCC":
            case "UCA":
            case "UCG":
                return "Serine";
            case "UAU":
            case "UAC":
                return "Tyrosine";
            case "UGU":
            case "UGC":
                return "Cysteine";
            case "UGG":
                return "Tryptophan";
            default:
                return "STOP";
        }
    }
    
    [Benchmark]
    [Arguments("UGGUGUUAUUAAUGGUUU")]
    [Arguments("UGGUAGUGG")]
    [Arguments("AUGUUUUAA")]
    [Arguments("UGGUAG")]
    public string[] LinQApproach(string strand) =>
        strand
            .Chunk(3)
            .Select(chunk => string.Concat(chunk))
            .Select(FindProtein)
            .TakeWhile(protein => protein != "STOP")
            .ToArray();
}

static class Program
{
    public static void Main()
    {
        var summary = BenchmarkRunner.Run<BenchMe>();
    }
}