namespace ValidAnagram_242;

internal static class Program
{
    public static void Main()
    {
        Console.WriteLine(IsAnagram("anagram", "nagaram"));
        Console.WriteLine(IsAnagram("rat", "car"));
    }
    
    private static bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) return false;

        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if(!dict.ContainsKey(c))
                dict.Add(c, 1);
            else
                dict[c]++;
        }

        foreach(char c in t)
        {
            if(dict.ContainsKey(c) && dict[c] > 0)
                dict[c]--;
            else
                return false;
        }

        return true;
    }
}