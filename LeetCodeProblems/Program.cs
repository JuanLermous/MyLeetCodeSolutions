//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//An input string is valid if:

//    Open brackets must be closed by the same type of brackets.
//    Open brackets must be closed in the correct order.
//    Every close bracket has a corresponding open bracket of the same type.

 

//Example 1:

//Input: s = "()"

//Output: true

//Example 2:

//Input: s = "()[]{}"

//Output: true

//Example 3:

//Input: s = "(]"

//Output: false

//Example 4:

//Input: s = "([])"

//Output: true

//Constraints:

//1 <= s.length <= 104
//    s consists of parentheses only '()[]{}'.


public class Solution

{
    public bool IsValid(string s)
    {
        s = "()";
        bool isTrue = false;
        char h;
        Stack<char> symbols = new Stack<char>();
        foreach (char c in s)
        {

            if (c != '(' || c!= '[' || c!= '{')
                return false;
            else
                symbols.Push(c);

            if(c== ')')
            {
                h = symbols.Pop();
                if (h == '(')
                    isTrue = true;
            }

            if (c == ']')
            {
                h = symbols.Pop();
                if (h == '[')
                    isTrue = true;
            }
            if (c == '}')
            {
                h = symbols.Pop();
                if (h == '{')
                    isTrue = true;
            }

        }
        return isTrue;
    }
}