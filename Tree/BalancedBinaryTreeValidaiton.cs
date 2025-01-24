namespace AlgorithmReview.Tree {
    public class BalancedBinaryTreeValidation {

        public bool IsBalanced(TreeNode root) {
            if (root == null) {
                return true;
            }

            return GetHeight(root) != -1;
        }

        private int GetHeight(TreeNode root) {
            if (root == null) {
                return 0;
            }

            int left = GetHeight(root.left);
            if (left == -1) return -1;

            int right = GetHeight(root.right);
            if (right == -1) return -1; 

            if (Math.Abs(left - right) > 1) {
                return -1;
            }

            return Math.Max(left, right) + 1;
        }
    }
}