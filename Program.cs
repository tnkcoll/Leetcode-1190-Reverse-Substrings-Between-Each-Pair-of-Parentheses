using System.ComponentModel.Design;
using System.Text;

namespace Leetcode_1190_Reverse_Substrings_Between_Each_Pair_of_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "yfgnxf";

            string reversedString = ReverseParentheses(s);

            Console.WriteLine(reversedString);

        }

        static string ReverseParentheses(string s)
        {
            var letterStack = new Stack<int>();
            var sb = new StringBuilder();

            foreach (char c in s)
            {
                if (c == '(')
                {
                    letterStack.Push(sb.Length);
                }
                else if (c == ')')
                {
                    int start = letterStack.Pop();
                    int end = sb.Length - 1;

                    ReverseSubstring(sb, start, end);
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        static void ReverseSubstring(StringBuilder sb, int start, int end)
        {
            while (start < end)
            {
                char temp = sb[start];
                sb[start] = sb[end];
                sb[end] = temp;
                start++;
                end--;
            }
        }
    }
}