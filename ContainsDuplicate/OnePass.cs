/*
 * Complexity Analysis:
 * Time complexity: O(n)
 * Space complexity O(1)
 */

namespace ContainsDuplicate;

public class OnePass : IDuplicateChecker
{
    public bool ContainsDuplicate(int[] nums)
    {
        var values = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (values.ContainsKey(nums[i])) return true;

            values.Add(nums[i], i);
        }

        return false;
    }
}