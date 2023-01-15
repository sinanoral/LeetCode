namespace ValidParentheses_20;

internal static class Program
{
    public static void Main()
    {
        string s = "()[]{}";
        Console.WriteLine(IsValid(s));

        string s1 = "([]{}";
        Console.WriteLine(IsValid(s1));
    }

    private static bool IsValid(string s)
    {

        if (s.Length % 2 != 0) return false;

        var brackets = new Stack<char>();

        foreach (var c in s)
        {
            if (c is '(' or '[' or '{')
            {
                brackets.Push(c);
            }
            else
            {
                if (brackets.Count == 0) return false;
                var b = brackets.Pop();
                switch (b)
                {
                    case '(' when c == ')':
                    case '[' when c == ']':
                    case '{' when c == '}':
                        continue;
                    default:
                        return false;
                }
            }
        }

        return brackets.Count == 0;
    }
}