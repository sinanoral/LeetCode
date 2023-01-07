namespace ContainsDuplicate_217;

internal static class Program
{
    public static void Main()
    {
        int[] nums1 = { 1, 2, 3, 1 };
        Console.WriteLine(ContainsDuplicate(nums1));

        int[] nums2 = { 1, 2, 3, 4 };
        Console.WriteLine(ContainsDuplicate2(nums2));

        int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
        Console.WriteLine(ContainsDuplicate3(nums3));
    }
    
    private static bool ContainsDuplicate(int[] nums) {
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] == nums[j])
                    return true;
            }
        }
        
        return false;
    }
    
    private static bool ContainsDuplicate2(int[] nums) {
        int l = new HashSet<int>(nums).Count;
        return l < nums.Length;
    }
    
    private static bool ContainsDuplicate3(int[] nums) {
        int l = nums.Distinct().Count();
        return l < nums.Length;
    }
}