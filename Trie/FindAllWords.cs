using System;
using System.Collections.Generic;

public class TrieNode {
    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    public string word = null; // 如果当前节点是单词的结尾，存储该单词
}

public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        List<string> result = new List<string>();

        // Step 1: 构造 Trie
        TrieNode root = BuildTrie(words);

        // Step 2: 遍历棋盘并回溯
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++) {
                Backtrack(board, i, j, root, result);
            }
        }

        return result;
    }

    private TrieNode BuildTrie(string[] words) {
        TrieNode root = new TrieNode();
        foreach (string word in words) {
            TrieNode node = root;
            foreach (char ch in word) {
                if (!node.children.ContainsKey(ch)) {
                    node.children[ch] = new TrieNode();
                }
                node = node.children[ch];
            }
            node.word = word; // 单词的末尾节点存储单词
        }
        return root;
    }

    private void Backtrack(char[][] board, int row, int col, TrieNode parent, List<string> result) {
        char letter = board[row][col];
        if (!parent.children.ContainsKey(letter)) {
            return; // 当前路径不存在于 Trie 中
        }

        TrieNode currentNode = parent.children[letter];

        // 检查是否找到单词
        if (currentNode.word != null) {
            result.Add(currentNode.word);
            currentNode.word = null; // 避免重复加入结果
        }

        // 标记当前单元格为已访问
        board[row][col] = '#';

        // 遍历 4 个方向
        int[] rowOffsets = {-1, 1, 0, 0};
        int[] colOffsets = {0, 0, -1, 1};
        for (int i = 0; i < 4; i++) {
            int newRow = row + rowOffsets[i];
            int newCol = col + colOffsets[i];
            if (newRow >= 0 && newRow < board.Length && newCol >= 0 && newCol < board[0].Length) {
                Backtrack(board, newRow, newCol, currentNode, result);
            }
        }

        // 恢复当前单元格
        board[row][col] = letter;

        // 优化：如果当前节点没有任何子节点，删除它
        if (currentNode.children.Count == 0) {
            parent.children.Remove(letter);
        }
    }

    public static void Main(string[] args) {
        Solution solution = new Solution();

        char[][] board1 = {
            new char[] {'o', 'a', 'a', 'n'},
            new char[] {'e', 't', 'a', 'e'},
            new char[] {'i', 'h', 'k', 'r'},
            new char[] {'i', 'f', 'l', 'v'}
        };
        string[] words1 = {"oath", "pea", "eat", "rain"};
        Console.WriteLine(string.Join(", ", solution.FindWords(board1, words1))); // 输出: ["oath", "eat"]

        char[][] board2 = {
            new char[] {'a', 'b'},
            new char[] {'c', 'd'}
        };
        string[] words2 = {"ab", "cb", "ad", "bd", "ac", "ca", "da", "bc", "db", "abcd"};
        Console.WriteLine(string.Join(", ", solution.FindWords(board2, words2))); // 输出: ["ab", "ac", "ad", "bd"]
    }
}
