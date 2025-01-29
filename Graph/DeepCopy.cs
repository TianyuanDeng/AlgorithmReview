namespace Graph.DeepCopy{
    public class Solution{

        public Dictionary<Node, Node> visited = new Dictionary<Node, Node>();
        public Node DFSDeepCopy(Node node){
            if (node == null){
                return null;
            }

            if (visited.ContainsKey(node)){
                return visited[node];
            }

            Node newNode = new Node(node.val, new List<Node>());
            visited.Add(node, newNode);

            foreach(var neighbors in node.neighbors){
                newNode.neighbors.Add(DeepCopy(neighbors));
            }

            return newNode;
        }

        public Node BFSDeepCopy(Node node){
            if (node == null){
                return null;
            }

            Dictionary<Node, Node> visited = new Dictionary<Node, Node>();
            Queue<Node> queue = new Queue<Node>();

            Node newNode = new Node(node.val, new List<Node>());
            
            queue.Enqueue(newNode);
            visited[node] = newNode;

            while(queue.Count > 0){
                Node current = queue.Dequeue();
                foreach(var neighbor in current.neighbors){
                    if (!visited.ContainsKey(neighbor)){

                        Node neighborNew = new Node(neighbor.val, new List<Node>());
                        visited[neighbor] = neighborNew;
                        queue.Enqueue(neighbor);
                    }
                    visited[current].neighbors.Add(visited[neighbor]);
                }
            }

            return newNode;
        }
    }
}