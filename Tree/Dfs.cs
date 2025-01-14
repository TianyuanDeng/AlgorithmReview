using System;
using System.Collections;
using System.Collections.Generic;

namespace Tree.Dfs{
    public class DFSRecursive {
        public void PreOrder(TreeNode root){
            if (root == null) return; 

            System.Console.WriteLine(root.val + " ");
            PreOrder(root.left);
            PreOrder(root.right);
        }

        public void InOrder(TreeNode root) {
            if (root == null) return;

            InOrder(root.left); // Traverse the left subtree
            Console.Write(root.val + " "); // Process the node
            InOrder(root.right); // Traverse the right subtree
        }

        public void PostOrder(TreeNode root) {
            if (root == null) return;

            PostOrder(root.left); // Traverse the left subtree
            PostOrder(root.right); // Traverse the right subtree
            Console.Write(root.val + " "); // Process the node
        }
    }

    public class DFSIterative {
        public void PreOrder(TreeNode root){
            if (root == null) return;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0) {
                TreeNode current = stack.Pop();
                Console.Write(current.val + " "); // Process the node

                // Push right child first so left child is processed first
                if (current.right != null) stack.Push(current.right);
                if (current.left != null) stack.Push(current.left);
            }
        }

        public void InOrder(TreeNode root) {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode current = root;

            while (current != null || stack.Count > 0) {
                // Reach the leftmost node
                while (current != null) {
                    stack.Push(current);
                    current = current.left;
                }

                // Process the node
                current = stack.Pop();
                Console.Write(current.val + " ");

                // Visit the right subtree
                current = current.right;
            }
        }

        public void PostOrder(TreeNode root) {
            if (root == null) return;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            Stack<TreeNode> output = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0) {
                TreeNode current = stack.Pop();
                output.Push(current);

                if (current.left != null) stack.Push(current.left);
                if (current.right != null) stack.Push(current.right);
            }

            while (output.Count > 0) {
                Console.Write(output.Pop().val + " ");
            }
        }
    }
}