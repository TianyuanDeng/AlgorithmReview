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
}