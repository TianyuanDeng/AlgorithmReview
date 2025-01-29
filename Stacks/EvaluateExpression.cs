namespace AlgorithmReview.Stacks{
    public class solution {
        public class EvaluateExpression {
            public int Evaluate(string expression){
                Stack<int> stack = new Stack<int>();
                int result = 0;
                int sign = 1;
                int num = 0;

                for (int i = 0; i < expression.Length; i++){
                    char c = expression[i];
                    if (Char.IsDigit(c)){
                        num = num * 10 + (c - '0');
                    } else if (c == '+'){
                        result += sign * num;
                        num = 0;
                        sign = 1;
                    } else if (c == '-'){
                        result += sign * num;
                        num = 0;
                        sign = -1;
                    } else if (c == '('){
                        stack.Push(result);
                        stack.Push(sign);
                        result = 0;
                        sign = 1;
                    } else if (c == ')'){
                        result += sign * num;
                        num = 0;
                        result *= stack.Pop();
                        result += stack.Pop();
                    }
                }

                if (num != 0){
                    result += sign * num;
                }

                return result;
            }
        }
    }
}