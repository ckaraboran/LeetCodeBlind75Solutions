// See https://aka.ms/new-console-template for more information

using TwoSum;

Calculate(new Bruteforce());
Calculate(new TwoPassHash());
Calculate(new OnePassHash());

static void Calculate(ITwoSumCalculator calculator)
{
    var values = new[] { 1, 3, 2, 6 };
    var result = calculator.TwoSum(values, 8);
    foreach (var item in result) Console.WriteLine(values[item]);
}