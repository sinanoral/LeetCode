public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        Queue<char> chars = new Queue<char>();
                
        int maxLength = int.MinValue;
        for(int windowEnd = 0; windowEnd < s.Length; windowEnd++)
        {
            while(chars.Contains(s[windowEnd]))
            {
                chars.Dequeue();
            }
            
            chars.Enqueue(s[windowEnd]);
            maxLength = Math.Max(maxLength, chars.Count);
        }
            
        return maxLength;
    }
}