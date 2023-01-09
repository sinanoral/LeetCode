namespace IntersectionOfTwoArraysII_350;

internal static class Program
{
    public static void Main()
    {
        int[] nums1 = { 1, 2, 2, 1 };
        int[] nums2 = { 2, 2 };
        var ret = Intersect(nums1, nums2);
        
        int[] nums3 = { 4, 9, 5 };
        int[] nums4 = { 9, 4, 8, 3 };
        var ret2 = Intersect(nums3, nums4);
    }

    private static int[] Intersect(int[] nums1, int[] nums2)
    {
        var dict = new Dictionary<int,int>();
        foreach(var i in nums1)
        {
            if (!dict.ContainsKey(i))
                dict.Add(i, 1);
            else
            {
                dict[i]++;
            }
        }
        
        var list = new List<int>();
        foreach(var i in nums2)
        {
            if (!dict.ContainsKey(i)) continue;
            list.Add(i);
            dict[i]--;
            if(dict[i] == 0)
                dict.Remove(i);
        }

        return list.ToArray();
    }
}