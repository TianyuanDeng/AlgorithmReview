public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        Dictionary<int, int> inorderMap = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; i++) {
            inorderMap[inorder[i]] = i;
        }

        return createTree(preorder, 0, inorder, 0, inorder.Length - 1, inorderMap);
    }

    public TreeNode createTree(int[] preorder, int preStart, int[] inorder, int inStart, int inEnd, Dictionary<int, int> inorderMap){
        if (preStart > preEnd || inStart > inEnd) {
            return null;
        }

        TreeNode root = new TreeNode(preorder[preStart]);
        int inRoot = inorderMap[root.val];

        root.left = createTree(preorder, preStart + 1， inorder, inStart, inRoot - 1, inorderMap);
        root.right = createTree(preorder, preStart + inRoot - inStart + 1, inorder, inRoot + 1, inEnd, inorderMap);

        return root;
    }
}