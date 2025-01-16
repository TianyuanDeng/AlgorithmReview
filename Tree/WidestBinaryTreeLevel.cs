public class Solution {
    public int WidthOfBinaryTree(TreeNode root) {
        if (root == null) {
            return 0;
        }

        int maxWidth = 0;
        Queue<(TreeNode, int)> queue = new Queue<Tuple<TreeNode, int>>();
        queue.Enqueue((root, 0));

    }
}