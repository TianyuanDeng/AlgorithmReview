namespace AlgorithmReview.Queue{
    public class CombineSortedLinkedList {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null) {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode MergeLists(List<ListNode> lists) {
            if (lists == null || lists.Count == 0) {
                return null;
            }

            var queue = new PriorityQueue<ListNode, int>();

            foreach (var list in lists) {
                if (list != null) {
                    queue.Enqueue(list, list.val);
                }
            }

            //Create a dummy head, and a current pointer to keep track of the current node
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            while (queue.Count > 0) {
                var node = queue.Dequeue();
                current.next = node;
                current = current.next;

                if (node.next != null) {
                    queue.Enqueue(node.next, node.next.val);
                }
            }

            //return dummy head
            return dummy.next;
        }
    }
}