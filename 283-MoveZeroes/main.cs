public class Solution {
    public void MoveZeroes(int[] nums) {
        
        if(nums.Length == 1)
            return;
       
        var p = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0) {
                nums[p++] = nums[i];
            }
        }
        
        while(p < nums.Length)
            nums[p++] = 0;
    }
}