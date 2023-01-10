namespace ReshapeTheMatrix_566;

internal static class Program
{
    public static void Main()
    {
        int[][] mat = { new[]{ 1, 2 }, new []{ 3, 4 } };
        int r = 3, c = 2;

        var matrixReshape = MatrixReshape(mat, r, c);
        for (int i = 0; i < matrixReshape.Length; i++)
        {
            for (int j = 0; j < matrixReshape[0].Length; j++)
            {
                Console.Write(matrixReshape[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
    
    private static int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        var matRow = mat.Length;
        var matCol = mat[0].Length;
        if (r * c != matRow * matCol || (matRow == r && matCol == c)) return mat;

        var flatten = new int[matRow * matCol];
        int k = 0;
        for (int i = 0; i < matRow; i++)
        {
            for (int j = 0; j < matCol; j++)
            {
                flatten[k++] = mat[i][j];
            }
        }

        k = 0;
        
        var reshaped = new int[r][];
        for (int i = 0; i < r; i++)
        {
            reshaped[i] = new int[c];
        }
        
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                reshaped[i][j] = flatten[k++];
            }
        }
        
        return reshaped;
    }
}