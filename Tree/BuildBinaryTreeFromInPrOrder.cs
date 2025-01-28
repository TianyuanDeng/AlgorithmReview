public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0 || inorder.Length == 0) return null;

        // 构造一个字典，用于快速定位中序序列中的索引
        Dictionary<int, int> inorderIndexMap = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; i++) {
            inorderIndexMap[inorder[i]] = i;
        }

        return Build(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1, inorderIndexMap);
    }

    private TreeNode Build(int[] preorder, int preStart, int preEnd, 
    int[] inorder, int inStart, int inEnd, 
    Dictionary<int, int> inorderIndexMap) {
        if (preStart > preEnd || inStart > inEnd) return null;

        // 前序遍历的第一个元素是根节点
        int rootVal = preorder[preStart];
        TreeNode root = new TreeNode(rootVal);

        // 找到根节点在中序遍历中的位置
        int rootIndex = inorderIndexMap[rootVal];
        int leftTreeSize = rootIndex - inStart;

        // 递归构造左子树
        root.left = Build(preorder, preStart + 1, preStart + leftTreeSize, 
            inorder, inStart, rootIndex - 1, inorderIndexMap);

        // 递归构造右子树
        root.right = Build(preorder, preStart + leftTreeSize + 1, preEnd, 
            inorder, rootIndex + 1, inEnd, inorderIndexMap);

        return root;
    }
}