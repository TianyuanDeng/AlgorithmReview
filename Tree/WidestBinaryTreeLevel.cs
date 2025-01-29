public class Solution {
    public int WidthOfBinaryTree(TreeNode root) {
        if (root == null) {
            return 0;
        }

        int maxWidth = 0;
        Queue<(TreeNode node, int index)> queue = new Queue<(TreeNode node, int index)>();
        queue.Enqueue((root, 1));
 
        while (queue.Count > 0){
            int count = queue.Count;
            int firstIndex = queue.Peek().index;
            int end = firstIndex;

            //Same logic as Rigt most, just need to track the first and last index
            for (int i = 0; i < count; i++){
                var (node, index) = queue.Dequeue();
                end = index;

                if (node.left != null){
                    queue.Enqueue((node.left, index * 2));
                }

                if (node.right != null){
                    queue.Enqueue((node.right, index * 2 + 1));
                }
            }

            maxWidth = Math.Max(maxWidth, end - firstIndex + 1);
        }

    }

    public int WidthOfBinaryTreeAvoidOverFlow(TreeNode root) {
        if (root == null) return 0;

        // 队列存储节点和它们的逻辑索引
        Queue<(TreeNode node, int index)> queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 1));

        int maxWidth = 0;

        while (queue.Count > 0) {
            int levelSize = queue.Count;
            int minIndex = queue.Peek().index; // 当前层最左节点的索引
            int firstIndex = 0, lastIndex = 0;

            for (int i = 0; i < levelSize; i++) {
                var (current, index) = queue.Dequeue();
                index -= minIndex; // 归一化索引

                if (i == 0) firstIndex = index; // 当前层最左节点
                if (i == levelSize - 1) lastIndex = index; // 当前层最右节点

                // 将左右子节点加入队列
                if (current.left != null) queue.Enqueue((current.left, 2 * index));
                if (current.right != null) queue.Enqueue((current.right, 2 * index + 1));
            }

            // 更新最大宽度
            maxWidth = Math.Max(maxWidth, lastIndex - firstIndex + 1);
        }

        return maxWidth;
    }
}