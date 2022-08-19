public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] result = new int[nums.Length];
        
        int l = 0;
        int r = nums.Length - 1;
        
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            if(Math.Abs(nums[l]) > Math.Abs(nums[r])) 
            {
                result[i] = nums[l] * nums[l];
                l++;
            }
            else 
            {
                result[i] = nums[r] * nums[r];
                r--;
            }
        }
        
        return result;
    }
}