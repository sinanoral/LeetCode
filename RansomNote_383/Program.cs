internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(CanConstruct("a", "b"));
        Console.WriteLine(CanConstruct("aa", "ab"));
    }
    
    private static bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> magazineDict = new Dictionary<char, int>();

        foreach(char c in magazine)
        {
            if(!magazineDict.ContainsKey(c))
                magazineDict.Add(c, 1);
            else
                magazineDict[c]++;
        }

        foreach(char c in ransomNote)
        {
            if(magazineDict.ContainsKey(c) && magazineDict[c] > 0)
                magazineDict[c]--;
            else
                return false;
        }

        return true;
    }
}