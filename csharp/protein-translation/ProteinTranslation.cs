using System;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
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

    private static string FindProtein(string codon)
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

    private static string[] LinQApproach(string strand) =>
        strand
            .Chunk(3)
            .Select(chunk => string.Concat(chunk))
            .Select(FindProtein)
            .TakeWhile(protein => protein != "STOP")
            .ToArray();
}