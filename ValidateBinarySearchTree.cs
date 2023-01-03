
namespace LeetCode
{
 
 // Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 
    public class ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, long.MinValue, long.MaxValue);
        }

        public bool IsValidBST(TreeNode current, long low, long high)
        {
            if (current == null) return true;
            if (current.val <= low || current.val >= high) return false;

            return IsValidBST(current.left, low, current.val) && IsValidBST(current.right, current.val, high);
        }
    }
}