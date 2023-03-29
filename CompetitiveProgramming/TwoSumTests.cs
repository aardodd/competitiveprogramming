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

    [Fact]
    public void TwoSum_GivenEmptyArray_ReturnsEmptyResults()
    {
        // Arrange
        var numbers = Array.Empty<int>();
        const int target = 0;
        
        // Act
        var actual = TwoSum(numbers, target);

        // Assert
        Assert.Empty(actual);
    }
    
    [Fact]
    public void TwoSum_GivenSingleElementArray_ReturnsEmptyResults()
    {
        // Arrange
        var numbers = new[] { 1 };
        const int target = 0;
        
        // Act
        var actual = TwoSum(numbers, target);

        // Assert
        Assert.Empty(actual);
    }

    [Theory]
    [InlineData(new[] { 1, 1 }, 2, new[] { 0, 1 })]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { -10, 3 }, -7, new[] { 0, 1 })]
    public void TwoSum_Tests(int[] numbers, int target, int[] expected)
    {
        var actual = TwoSum(numbers, target);
        
        Assert.Equal(expected[0], actual[0]);
        Assert.Equal(expected[1], actual[1]);
    }
}