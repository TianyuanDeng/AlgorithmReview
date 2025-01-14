using System;
using System.Collections.Generic;

namespace Tree.Bfs{
    public class  BFS{
        public void LevelOrder(TreeNode root) {
        if (root == null) return;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            TreeNode current = queue.Dequeue();
            Console.Write(current.val + " "); // Process the node

            if (current.left != null) queue.Enqueue(current.left);
            if (current.right != null) queue.Enqueue(current.right);
        }
    }
    }
}