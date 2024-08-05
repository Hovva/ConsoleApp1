using System.Runtime.InteropServices;

namespace ClassLibrary1;

public class Arrays
{
    public static void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;
        int[] RotatedNums = new int[nums.Length];
        for (int i = nums.Length - k; i < nums.Length; ++i)
            RotatedNums[i - nums.Length + k] = nums[i];
        for (int i = 0; i < nums.Length - k; ++i)
            RotatedNums[i + k] = nums[i];
        for (int i = 0; i < nums.Length; ++i)
            nums[i] = RotatedNums[i];
    }
    public static int RemoveDuplicates(int [] nums)
    {
        List<int> result = new() {nums[0]};
        int answer = 1;
        for (int i = 1; i < nums.Length; ++i)
        {
            if (nums[i] != nums[i - 1])
            {
                result.Add(nums[i]);
                answer++;
            }
        }

        for (int i = 0; i < answer; ++i)
            nums[i] = result[i];
        return  answer;
    }
    public static int MaxProfit(int[] prices)
    {
        if (prices.Length < 2)
            return 0; 

        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1])
            {
                maxProfit += prices[i] - prices[i - 1];
            }
        }

        return maxProfit;
    }

    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        List<int> result = new List<int>();
        if (nums1.Length > nums2.Length)
            (nums1, nums2) = (nums2, nums1);
        bool[] used = new bool[nums2.Length];
        for (int i = 0; i < nums1.Length; ++i)
            for (int j = 0; j < nums2.Length; ++j)
                if (nums1[i] == nums2[j] && !used[j])
                {
                    used[j] = true;
                    result.Add(nums2[j]);
                    break;
                }
        return result.ToArray();
    }

    public static bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, int> numsD = new();
        foreach (var v in nums)
            if (!numsD.TryAdd(v, 1))
                return true;
        return false;
    }
    public static int[] PlusOne(int[] digits) {
        for (int i = digits.Length - 1; i >=0;--i)
            if (digits[i] == 9)
                digits[i] = 0;
            else
            {
                digits[i]++;
                return digits;
            }

        int[] result = new int[digits.Length+1];
        result[0] = 1;
        for (int i = 0; i < digits.Length; ++i)
            result[1 + i] = digits[0];
        return result;
    }
    
}