/*
Given an array of integers numbers and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
*/
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