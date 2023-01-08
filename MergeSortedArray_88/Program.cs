namespace MergeSortedArray_88;

internal static class Program
{
    public static void Main()
    {
        const int m = 3, n = 3;
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };
        
        Merge(nums1, m, nums2, n);
        
        foreach (var i in nums1)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("-------------");

        int[] nums3 = { 2, 5, 6, 0, 0, 0 };
        int[] nums4 = { 1, 2, 3 };
        
        Merge2(nums3, m, nums4, n);
        
        foreach (var i in nums3)
        {
            Console.WriteLine(i);
        }
    }

    private static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m - 1, p2 = n - 1;
        int k = m + n - 1;
        while (p2 >= 0)
        {
            if (p1 >= 0 && nums1[p1] > nums2[p2])
            {
                nums1[k] = nums1[p1];
                p1--;
                k--;
            }
            else
            {
                nums1[k] = nums2[p2];
                p2--;
                k--;
            }
        }
    }
    
    private static void Merge2(int[] nums1, int m, int[] nums2, int n) {
        for(int i = 0; i < n; i++)
        {
            nums1[i + m] = nums2[i];
        }

        Array.Sort(nums1);
    }
}