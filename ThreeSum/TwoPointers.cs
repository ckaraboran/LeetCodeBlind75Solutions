//Runtime: 47 ms, faster than 35.83% of Java online submissions for 3Sum.
//Memory Usage: 60.1 MB, less than 32.20% of Java online submissions for 3Sum.
//Two pointers
//Time: O(N * LogN + N * N); Space : O(N + LogN)

namespace ThreeSum;

public class TwoPointers : IThreeSumFinder
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var resultSet = new HashSet<List<int>>();
        Array.Sort(nums);
        for (var i = 0; i <= nums.Length - 3 && nums[i] <= 0;)
        {
            int left = i + 1, right = nums.Length - 1;
            if (0 - nums[i] - nums[left] < 0) break;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];
                if (sum > 0)
                {
                    right--;
                    while (left < right && nums[right] == nums[right + 1]) right--; //skip duplicated number
                }
                else
                {
                    if (sum == 0)
                    {
                        resultSet.Add(new List<int> { nums[i], nums[left], nums[right] });
                        right--;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                    }

                    left++;
                    while (left < right && nums[left] == nums[left - 1]) left++;
                }
            }

            i++;
            while (i < nums.Length - 2 && nums[i] == nums[i - 1]) i++;
        }

        return new List<IList<int>>(resultSet);
    }
}