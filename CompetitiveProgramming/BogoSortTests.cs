using System.Security.Cryptography;

namespace CompetitiveProgramming;

public class BogoSortTests
{
    private static bool BogoSort(IList<int> items)
    {
        while (!IsSorted(items))
        {
            Shuffle(items);
        }
        
        return true;
    }

    private static bool IsSorted(IList<int> items)
    {
        for (var i = 1; i < items.Count; i++)
        {
            if (items[i] < items[i - 1])
            {
                return false;
            }
        }

        return true;
    }

    private static void Shuffle(IList<int> items)
    {
        var n = items.Count;

        for (var i = 0; i < n - 1; i++)
        {
            var j = RandomNumberGenerator.GetInt32(i, n);

            if (i != j)
            {
                (items[i], items[j]) = (items[j], items[i]);
            }
        }
    }

    [Fact]
    public void BogoSort_GivenASortedList_SortsTheList()
    {
        // Arrange
        var input = new List<int> { 1, 2, 3 };
        
        // Act
        BogoSort(input);

        // Assert
        input.Should().BeInAscendingOrder();
    }
    
    /// <summary>
    /// Test that the <c>BogoSort</c> method sorts an unsorted list.
    /// </summary>
    [Fact]
    public void BogoSort_GivenAUnsortedList_SortsTheList()
    {
        // Arrange
        var input = new List<int> { 2, 1, 3, 5, 10, -1, -105, 8392 };
        
        // Act
        BogoSort(input);

        // Assert
        input.Should().BeInAscendingOrder();
    }
}