public class Solution {
    private int maxSum = int.MinValue;

    public int MaxPathSum(TreeNode root) {
        CalculateMaxSum(root);
        return maxSum;
    }

    public int CalculateMaxSum(TreeNode root){
        if (root == null){
            return 0;
        }

        int leftSum = Math.Max(0, CalculateMaxSum(root.left));
        int rightSum = Math.Max(0, CalculateMaxSum(root.right));

        int currentSum = root.val + leftSum + rightSum;
        maxSum = Math.Max(maxSum, currentSum);

        return root.val + Math.Max(leftSum, rightSum);
    }
}