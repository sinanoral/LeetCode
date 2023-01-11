namespace SearchA2DMatrix;

internal static class Program
{
    public static void Main()
    {
        int[][] arr =
        {
            new [] { 1, 3, 5, 7 }, 
            new [] { 10, 11, 16, 20 }, 
            new [] { 23, 30, 34, 60 }
        };

        Console.WriteLine(SearchMatrix(arr, 3));
    }

    private static bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix.Length == 0 || matrix[0].Length == 0)
            return false;

        int m = matrix.Length;
        int n = matrix[0].Length;

        int low = 0, high = m * n - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int midVal = matrix[mid / n][mid % n];
            if (midVal == target)
                return true;
            if (midVal < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return false;
    }
}