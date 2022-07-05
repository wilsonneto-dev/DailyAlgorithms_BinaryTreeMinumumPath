public class Solution {
    public int MinDepth(TreeNode root) {
        if(root is null)
            return 0;
        
        Queue<(TreeNode, int)> queue = new();
        queue.Enqueue((root, 1));
        
        while(queue.Count > 0)
        {
            var (node, level) = queue.Dequeue();
            if(node.left is null && node.right is null)
                return level;
            
            if(node.left is not null) queue.Enqueue((node.left, level + 1));
            if(node.right is not null) queue.Enqueue((node.right, level + 1));
        }
        return -1;
    }
}
