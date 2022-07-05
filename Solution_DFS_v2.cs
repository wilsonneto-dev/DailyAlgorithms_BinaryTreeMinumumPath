public class Solution {
    public int MinDepth(TreeNode root, int currentLength = 1) {
        if(root is null)
            return currentLength -1;
        
        if(root?.left is null && root?.right is null)
            return currentLength;
        
        if(root.left is null)
            return MinDepth(root.right, currentLength + 1);
        if(root.right is null)
            return MinDepth(root.left, currentLength + 1);
        
        int minDepthLeft = MinDepth(root.left, currentLength + 1);
        int minDepthRight = MinDepth(root.right, currentLength + 1);
        
        return (minDepthLeft < minDepthRight) ? minDepthLeft : minDepthRight;
    }
}
