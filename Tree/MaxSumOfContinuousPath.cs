namespace AlgorithmReview.Tree {
    public class solution {
        private int maxSum = int.MinValue;

        public int MaxPathSum(TreeNode root) {
            CalculateMaxPathSum(root);
            return maxSum;
        }

        private int CalculateMaxPathSum(TreeNode node) {
            if (node == null) return 0;

            // 计算左右子树的最大贡献值，负值置为 0
            int left = Math.Max(0, CalculateMaxPathSum(node.left));
            int right = Math.Max(0, CalculateMaxPathSum(node.right));

            // 当前节点的路径和
            int currentPathSum = node.val + left + right;

            // 更新全局最大路径和
            maxSum = Math.Max(maxSum, currentPathSum);

            // 返回当前节点的最大贡献值
            // Tricky part: 只能返回单边+当前节点的值，不能返回两边+当前节点的值
            return node.val + Math.Max(left, right);
        }
    }
}