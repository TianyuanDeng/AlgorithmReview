public class Solution {
    public bool IsValidBST(TreeNode root) {
       return validBST(root, Int32.MinValue, Int32.MaxValue);
    }

    public bool validBST(TreeNode node, int min, int max){
        if (root == null) {
            return true;
        }

        if (min != null && node.val <= min) {
            return false;
        }

        if (max != null && node.val >= max) {
            return false;
        }

        return validBST(node.left, min, node.val) && validBST(node.right, node.val, max);
    }
}