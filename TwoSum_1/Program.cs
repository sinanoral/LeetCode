namespace TwoSum_1;

internal static class Program
{
    public static void Main()
    {
        int[] nums1 = { 2, 7, 11, 15 };
        Console.WriteLine(TwoSum(nums1, 9));

        int[] nums2 = { 3, 2, 4 };
        Console.WriteLine(TwoSum2(nums2, 6));
    }

    private static int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new[] { i, j };
            }
        }

        return null!;
    }

    private static int[] TwoSum2(int[] nums, int target)
    {
        var hash = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (hash.ContainsKey(diff))
                return new[] { hash[diff], i };
            if (!hash.ContainsKey(nums[i]))
                hash.Add(nums[i], i);
        }

        return null!;
    }
}