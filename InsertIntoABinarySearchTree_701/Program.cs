﻿internal static class Program
{
    public static void Main()
    {
        
    }
    
    public static TreeNode InsertIntoBST(TreeNode root, int val) {
        if(root == null) return new TreeNode(val);
        if(val > root.val) root.right = InsertIntoBST(root.right, val);
        if(val < root.val) root.left = InsertIntoBST(root.left, val);
        return root;
    }
    
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
}