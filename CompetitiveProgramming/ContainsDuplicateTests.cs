namespace CompetitiveProgramming;

public class ContainsDuplicateTests
{
    private static bool ContainsDuplicate(int[] numbers)
    {
        var seen = new HashSet<int>();
        return numbers.Length > 1 && numbers.Any(n => !seen.Add(n));
    }

    [Theory]
    [InlineData(new int[] {}, false)]
    [InlineData(new[] { 1 }, false)]
    [InlineData(new[] { 1, 2 }, false)]
    [InlineData(new[] { 1, 1 }, true)]
    public void ContainsDuplicate_Tests(int[] numbers, bool expected)
    {
        var actual = ContainsDuplicate(numbers);
        actual.Should().Be(expected);
    }
}