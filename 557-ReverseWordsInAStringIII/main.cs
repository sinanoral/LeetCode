public class Solution {
    public string ReverseWords(string s) {
        int p = 0;
        string result = "";
        
        int k = 0;
        while(k < s.Length)
        {
            if(s[k] == ' ')
            {
                for(int i = k - 1; i >= p; i--)
                {
                    result += s[i];
                }
                p = k + 1;
                result += ' ';
            }
            k++;
        }
        
        int n = s.Length - 1;
        while(n >= 0 && s[n] != ' ') {
            result += s[n];
            n--;
        }
        
        return result;
    }
}