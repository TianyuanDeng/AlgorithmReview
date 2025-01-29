namespace Graph {
    public class Node {
        public int val;
        public List<Node> neighbors;
        public Node(int val = 0, List<Node> neighbors = null) {
            this.val = val;
            this.neighbors = neighbors;
        }
    }
}