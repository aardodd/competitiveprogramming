namespace CompetitiveProgramming;

public class ValidParenthesesTests
{
    private static bool ValidParentheses(string s)
    {
        var stack = new Stack<char>();
        var pairs = new Dictionary<char, char>()
        {
            [')'] = '(',
            [']'] = '[',
            ['}'] = '{',
        };

        foreach (var c in s)
        {
            if (!pairs.ContainsKey(c) && !pairs.ContainsValue(c))
            {
                return false;
            }

            if (!pairs.ContainsKey(c))
            {
                stack.Push(c);
            }
            else if (stack.Count == 0 || stack.Pop() != pairs[c])
            {
                return false;
            }
        }

        return stack.Count == 0;
    }

    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("((){})", true)]
    [InlineData("(]", false)]
    [InlineData("(defun x (x y) (* x y))", false)]
    [InlineData("((){}", false)]
    public void ValidParentheses_Tests(string s, bool expected)
    {
        var actual = ValidParentheses(s);
        Assert.Equal(expected, actual);
    }
}