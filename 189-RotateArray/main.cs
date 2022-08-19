public class Solution {
    public void Rotate(int[] nums, int k) {
        var length = nums.Length;
        k %= length--;
        Reverse(nums, 0, length);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, length);
    }
    
	
    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            var temp = nums[start];
            nums[start++] = nums[end];
            nums[end--] = temp;
        }
    }
}