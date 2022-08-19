public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int low = 0;
        int high = nums.Length - 1;
        
        if(target > nums[high])
            return high + 1;
        
        while(low < high)
        {
            int mid = low + (high - low) / 2;
            
            if(target > nums[mid]) low = mid + 1;
            else high = mid;
        }
        
        if(target == nums[low])
            return low;
        
        int i = 0;
        while(nums[i] < target)
        {
            i++;
        }
        
        if(i <= nums.Length - 1)
            return i;
        
        return i + 1;
    }
}