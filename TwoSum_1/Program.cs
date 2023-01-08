namespace TwoSum_1;

internal static class Program
{
    public static void Main()
    {
        int[] nums1 = { 2, 7, 11, 15 };
        var twoSum = TwoSum(nums1, 9);
        foreach (var i in twoSum)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("--------------------");

        int[] nums2 = { 3, 2, 4 };
        var twoSum2 = TwoSum2(nums2, 6);
        foreach (var i in twoSum2)
        {
            Console.WriteLine(i);
        }
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