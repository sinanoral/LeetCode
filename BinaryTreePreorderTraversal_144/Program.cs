namespace BinaryTreePreorderTraversal_144;

public class TreeNode
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

internal static class Program
{
    public static void Main()
    {

    }

    private static IList<int> PreorderTraversal(TreeNode root)
    {
        IList<int> preorder = new List<int>();

        var stack = new Stack<TreeNode>();
        TreeNode node = root;

        if (node != null)
            stack.Push(node);

        while (stack.Count > 0)
        {
            node = stack.Pop();
            preorder.Add(node.val);

            if (node.right is not null)
            {
                stack.Push(node.right);
            }

            if (node.left != null)
            {
                stack.Push(node.left);
            }
        }

        return preorder;
    }
}