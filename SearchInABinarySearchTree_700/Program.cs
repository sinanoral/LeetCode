internal static class Program
{
    public static void Main()
    {
        
    }
    
    public static TreeNode SearchBST(TreeNode root, int val) {
        if(root == null || root.val == val) return root;

        return SearchBST(root.val > val ? root.left : root.right, val);
    }
}

internal class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}