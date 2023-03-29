namespace CompetitiveProgramming;

public class ValidAnagramTests
{
    private static bool ValidAnagram(string left, string right)
    {
        if (string.IsNullOrWhiteSpace(left) || string.IsNullOrWhiteSpace(right))
        {
            return false;
        }
        
        if (left.Length != right.Length)
        {
            return false;
        }

        if (left == right)
        {
            return true;
        }

        var leftCharacterCount = new Dictionary<char, int>();
        foreach (var c in left)
        {
            leftCharacterCount[c] = leftCharacterCount.GetValueOrDefault(c) + 1;
        }
        
        var rightCharacterCount = new Dictionary<char, int>();
        foreach (var c in right)
        {
            rightCharacterCount[c] = rightCharacterCount.GetValueOrDefault(c) + 1;
        }

        return !(from c in leftCharacterCount.Keys
            let rightCount = rightCharacterCount.GetValueOrDefault(c)
            where leftCharacterCount[c] != rightCount
            select c).Any();
    }

    [Theory]
    [InlineData("", "", false)]
    [InlineData("a", "a", true)]
    [InlineData("1", "12", false)]
    [InlineData("race", "care", true)]
    [InlineData("race", "horn", false)]
    public void ValidAnagram_Tests(string s, string t, bool expected)
    {
        var actual = ValidAnagram(s, t);
        Assert.Equal(expected, actual);
    }
}