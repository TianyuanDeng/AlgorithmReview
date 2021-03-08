using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmReview
{
    class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<Char> stk = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stk.Push(')');
                }
                else if (s[i] == '[')
                {
                    stk.Push(']');
                }
                else if (s[i] == '{')
                {
                    stk.Push('}');
                }
                else
                {
                    if (stk.Count == 0 || stk.Pop() != s[i])
                        return false;
                }
            }

            return (stk.Count != 0) ? false : true;
        }
    }
}
