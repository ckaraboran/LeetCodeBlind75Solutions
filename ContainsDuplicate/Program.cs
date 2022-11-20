/*
 * Given an integer array nums, return true if any value appears at least twice in the array,
 * and return false if every element is distinct.
 */
using ContainsDuplicate;

Calculate(new OnePass());

void Calculate(IDuplicateChecker calculator)
{
    var values = new[] { 6, 2, 8, 1, 7, 3, 4 };
    var result = calculator.ContainsDuplicate(values);
    Console.WriteLine(result);
}