using SumOfNumbers;

const long Limit = 1_000_000;
var sumByBrute = new SumOfNBrute(Limit);
var sumByformula = new SumOfNByFormula(Limit);

PrintSum.Print(sumByBrute);
PrintSum.Print(sumByformula);

internal class PrintSum
{
    public static void Print(ISumOfN summation)
    {
        var result = summation.Calculate();
        Console.WriteLine(result);
    }
}
