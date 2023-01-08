namespace MaximumSubarray_53;

internal static class Program
{
    public static void Main()
    {
        int[] nums1 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine(MaxSubArray(nums1));

        int[] nums2 = { 1 };
        Console.WriteLine(MaxSubArray2(nums2));

        int[] nums3 = { 5, 4, -1, 7, 8 };
        Console.WriteLine(MaxSubArray3(nums3));
    }

    private static int MaxSubArray(int[] nums)
    {
        int maxSum = Int32.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            int currentSum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                currentSum += nums[j];
                if (currentSum >= maxSum) maxSum = currentSum;
            }
        }

        return maxSum;
    }
    
    // kadane's algorithm
    private static int MaxSubArray2(int[] nums)
    {
        int maxSum = Int32.MinValue;
        int currentSum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];
            if(currentSum > maxSum) maxSum = currentSum;
            if(currentSum < 0) currentSum = 0;
        }

        return maxSum;
    }
    
    private static int MaxSubArray3(int[] nums)
    {
        int prev = nums[0];
        int max = prev;

        for(int i = 1; i < nums.Length; i++)
        {
            prev = Math.Max(nums[i], prev + nums[i]);
            max = Math.Max(max, prev);
        }

        return max;
    }
}