using System;
using System.Collections.Generic;

public class TrieNode {
    public Dictionary<char, TrieNode> children; // 子节点
    public bool isEnd; // 是否是单词结尾

    public TrieNode() {
        children = new Dictionary<char, TrieNode>();
        isEnd = false;
    }
}

public class Trie {
    private TrieNode root; // 根节点

    public Trie() {
        root = new TrieNode();
    }

    // 插入单词
    public void Insert(string word) {
        TrieNode node = root;
        foreach (char ch in word) {
            if (!node.children.ContainsKey(ch)) {
                node.children[ch] = new TrieNode();
            }
            node = node.children[ch];
        }
        node.isEnd = true; // 标记单词结束
    }

    // 查找单词
    public bool Search(string word) {
        TrieNode node = FindNode(word);
        return node != null && node.isEnd;
    }

    // 查找前缀
    public bool StartsWith(string prefix) {
        TrieNode node = FindNode(prefix);
        return node != null;
    }

    // 辅助函数：根据字符串找到最后一个字符对应的节点
    private TrieNode FindNode(string prefix) {
        TrieNode node = root;
        foreach (char ch in prefix) {
            if (!node.children.ContainsKey(ch)) {
                return null;
            }
            node = node.children[ch];
        }
        return node;
    }

    public static void Main(string[] args) {
        Trie trie = new Trie();

        trie.Insert("apple");
        Console.WriteLine(trie.Search("apple"));   // 输出: true
        Console.WriteLine(trie.Search("app"));     // 输出: false
        Console.WriteLine(trie.StartsWith("app")); // 输出: true

        trie.Insert("app");
        Console.WriteLine(trie.Search("app"));     // 输出: true
    }
}
