//Runtime: 106 ms, faster than 29.54% of Java online submissions for 3Sum.
//Memory Usage: 70.8 MB, less than 23.87% of Java online submissions for 3Sum.
//HashMap
//Time:O(N * logN + N * N); Space: O(N + logN + N)

namespace ThreeSum;

public class BinarySearch : IThreeSumFinder
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var resultSet = new HashSet<List<int>>();
        Array.Sort(nums);
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++) map[nums[i]] = i;

        for (var i = 0; i < nums.Length - 2 && nums[i] <= 0;)
        {
            for (var j = i + 1; j < nums.Length && nums[i] + nums[j] <= 0;)
            {
                var value = 0 - nums[i] - nums[j];
                //if (value < 0) break;
                if (value < 0) return new List<IList<int>>(resultSet);
                if (value < nums[j]) break;
                if (map.ContainsKey(value) && map[value] > j)
                    resultSet.Add(new List<int> { nums[i], nums[j], value });
                j++;
                while (j < nums.Length && nums[j] == nums[j - 1]) j++;
            }

            i++;
            while (i < nums.Length - 2 && nums[i] == nums[i - 1]) i++;
        }

        return new List<IList<int>>(resultSet);
    }
}