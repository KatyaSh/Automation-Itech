using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StackMethods
{
    public static Stack<int> AscSorting(Stack<int> stack)
    {
        Stack<int> result = new Stack<int>();

        while (stack.Count > 0)
        {
            int max = stack.Max();
            Stack<int> tempStack = new Stack<int>();

            while (stack.Count > 0)
            {
                int tempElement = stack.Pop();
                if (max > tempElement)
                {
                    tempStack.Push(tempElement);
                }
            }

            stack = tempStack;
            result.Push(max);
        }

        return result;
    }

    public static bool AreParenthesesBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in input)
        {
            if (ch == '(')
            {
                stack.Push(ch);
            }
            else if (ch == ')')
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }
}



