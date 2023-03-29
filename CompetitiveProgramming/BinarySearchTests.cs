namespace CompetitiveProgramming;

public class BinarySearchTests
{
    private static int BinarySearch(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left <= right)
        {
            var middlePoint = left + ((right - left) / 2);
            
            if (target < numbers[middlePoint])
            {
                right = middlePoint - 1;
            }
            else if (target > numbers[middlePoint])
            {
                left = middlePoint + 1;
            }
            else
            {
                return middlePoint;
            }
        }

        return -1;
    }

    [Theory]
    [InlineData(new[] { -1, 5, 0, 3, 7 }, -1, 0)]
    [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
    public void BinarySearch_Tests(int[] numbers, int target, int expected)
    {
        Array.Sort(numbers);
        
        var actual = BinarySearch(numbers, target);
        actual.Should().Be(expected);
    }
}