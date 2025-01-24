namespace AlgorithmReview.Tree{
    public class LowestCommonAncestor {


        public TreeNode FindLowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
            if (root == null || root == p || root == q) {
                return root;
            }

            TreeNode left = FindLowestCommonAncestor(root.left, p, q);
            TreeNode right = FindLowestCommonAncestor(root.right, p, q);

            if (left != null && right != null) {
                return root;
            }

            return left != null ? left : right;
        }
    }
}