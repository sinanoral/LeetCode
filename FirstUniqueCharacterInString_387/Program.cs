namespace FirstUniqueCharacterInString_387;

internal static class Program
{
    public static void Main()
    {
        Console.WriteLine(FirstUniqChar("leetcode"));
    }
    
    private static int FirstUniqChar(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        
        foreach (var c in s)
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict.Add(c, 1);
        }
        
        foreach (var (key, value) in dict)
        {
            if (value == 1)
            {
                return s.IndexOf(key);
            }
        }

        return -1;
    }
}