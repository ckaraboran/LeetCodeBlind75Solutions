/*
Complexity Analysis:
Time complexity: O(n)
Space complexity O(1)
 */

namespace ProductOfArrayExceptSelf;

public class TwoPass : IProductsCalculator
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] res = new int[n];
        res[0] = 1;
        // Calculate lefts and store in res.
        for (int i = 1; i < n; i++)
        {
            res[i] = res[i - 1] * nums[i - 1];
        }

        int right = 1;
        // Calculate rights and the product from the end of the array.
        for (int i = n - 1; i >= 0; i--)
        {
            res[i] *= right;
            right *= nums[i];
        }

        return res;
    }
}