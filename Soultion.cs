/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MinDepth(TreeNode root, int currentLength = 0) {
        if(root is null)
            return currentLength;
        
        if(root.left is null) return MinDepth(root.right, currentLength + 1);
        if(root.right is null) return MinDepth(root.left, currentLength + 1);
        
        int leftDepth = MinDepth(root.left, currentLength + 1);
        int rightDepth = MinDepth(root.right, currentLength + 1);
        
        return leftDepth < rightDepth ? leftDepth : rightDepth;
    }
}
