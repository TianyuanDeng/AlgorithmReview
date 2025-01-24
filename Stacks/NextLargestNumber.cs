namsespace AlgorithmReview.Stacks
{
    public class solution {
        public int[] NextLargestNumber(int[] nums){
            int[] result = new int[nums.Length];

            stack<int> stack = new Stack<int>();

            for (int i = nums.Length - 1; i >= 0; i--){
                while (stack.Count > 0 && stack.Peek() <= nums[i]){
                    stack.Pop();
                }

                result[i] = stack.Count > 0 ? stack.Peek() : -1;
                stack.Push(nums[i]);
            }

            return result;
        }
    }
}