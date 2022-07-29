# 📚 DailyAlgorithms_BinaryTreeMinumumPath



https://leetcode.com/problems/minimum-depth-of-binary-tree/submissions/


        public int MinDepth(TreeNode root) {
        /*

        DFS

        if(root is null && level == 1)
            return 0;
        
        if(root.left is null && root.right is null)
            return level;
        
        if(root.right is null)
            return MinDepth(root.left, level + 1);
        
        if(root.left is null)
            return MinDepth(root.right, level + 1);
        
        var leftDeep = MinDepth(root.left, level + 1);
        var rightDeep = MinDepth(root.right, level + 1);
        return leftDeep < rightDeep ? leftDeep : rightDeep;
        */
        
        // BFS
        
        if(root is null) return 0;
        
        var queue = new Queue<(TreeNode, int)>();
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
