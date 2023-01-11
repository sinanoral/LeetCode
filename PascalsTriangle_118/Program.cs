namespace PascalsTriangle_118;

internal static class Program
{
    public static void Main()
    {
        var pascal = Generate(5);
    }

    private static IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> pascal= new List<IList<int>>(numRows);
        for(int i = 0; i< numRows; i++)
        {
            var row = new List<int>();
            for(int j = 0; j <= i; j++)
            {
                if((j - 1) < 0 || (j + 1) > i) 
                    row.Add(1);
                else  
                    row.Add(pascal[i - 1][j - 1] + pascal[i - 1][j]);
            }
            pascal.Add(row);
        }
        
        return pascal; 
    }
}