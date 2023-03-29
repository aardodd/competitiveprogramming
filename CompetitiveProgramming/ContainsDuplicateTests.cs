namespace CompetitiveProgramming;

public class ContainsDuplicateTests
{
    private static bool ContainsDuplicate(int[] numbers)
    {
        if (numbers.Length <= 1)
        {
            return false;
        }

        var seenNumbers = new HashSet<int>();
        foreach (var n in numbers)
        {
            if (seenNumbers.Contains(n))
            {
                return true;
            }

            seenNumbers.Add(n);
        }
        
        return false;
    }

    [Theory]
    [InlineData(new int[] {}, false)]
    [InlineData(new[] { 1 }, false)]
    [InlineData(new[] { 1, 2 }, false)]
    [InlineData(new[] { 1, 1 }, true)]
    public void ContainsDuplicate_Tests(int[] numbers, bool expected)
    {
        var actual = ContainsDuplicate(numbers);
        Assert.Equal(expected, actual);
    }
}