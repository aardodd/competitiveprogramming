namespace CompetitiveProgramming;

public class TwoSumTests
{
    private static int[] TwoSum(int[] numbers, int target)
    {
        if (numbers.Length <= 1)
        {
            return Array.Empty<int>();
        }

        var complements = new Dictionary<int, int>();
        for (var i = 0; i < numbers.Length; i++)
        {
            var n = numbers[i];
            var complement = target - n;

            if (complements.TryGetValue(complement, out var value))
            {
                return new[] { value, i };
            }
            
            complements[n] = i;
        }
        
        return Array.Empty<int>();
    }

    [Theory]
    [InlineData(new int[] {}, 0)]
    [InlineData(new int[] { 1 }, 0)]
    [InlineData(new int[] { 1, 2 }, 4)]
    public void TwoSum_TestEmptyResults(int[] numbers, int target)
    {
        var actual = TwoSum(numbers, target);
        actual.Should().BeEmpty();
    }

    [Theory]
    [InlineData(new[] { 1, 1 }, 2, new[] { 0, 1 })]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { -10, 3 }, -7, new[] { 0, 1 })]
    public void TwoSum_TestResults(int[] numbers, int target, int[] expected)
    {
        var actual = TwoSum(numbers, target);
        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
}