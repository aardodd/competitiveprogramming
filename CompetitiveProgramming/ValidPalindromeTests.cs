namespace CompetitiveProgramming;

public class ValidPalindromeTests
{
    private static bool ValidPalindrome(string s)
    {
        s = s.ToLower();

        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (c is >= 'a' and <= 'z' or >= '0' and <= '9')
            {
                continue;
            }
            
            s = s.Remove(i);
            i--;
        }
        
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            
            left += 1;
            right -= 1;
        }
        
        return true;
    }

    [Theory]
    [InlineData("", true)]
    [InlineData(" ", true)]
    [InlineData("a", true)]
    [InlineData("aa", true)]
    [InlineData("aaa", true)]
    [InlineData("aba", true)]
    [InlineData("ab", false)]
    [InlineData("abc", false)]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    public void ValidPalindrome_Tests(string s, bool expected)
    {
        var actual = ValidPalindrome(s);
        actual.Should().Be(expected);
    }
}