public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        if (root == null) {
            return new List<int>();
        }
        
        List<int> result = new List<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            int size = queue.Count;
            for (int i = 0; i < size; i++) {
                TreeNode node = queue.Dequeue();
                if (i == size - 1) {
                    result.Add(node.val);
                }
                
                if (node.left != null) {
                    queue.Enqueue(node.left);
                }
                
                if (node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
        }

        return result;
    }
}