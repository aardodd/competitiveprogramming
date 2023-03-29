namespace CompetitiveProgramming;

public class MergedSortedLinkedListsTests
{
    private static ListNode? MergedSortedLists(ListNode? left, ListNode? right)
    {
        var dummy = new ListNode();
        var tail = dummy;
        
        while (left != null && right != null)
        {
            if (left.Value < right.Value)
            {
                tail.Next = left;
                left = left.Next;
            }
            else
            {
                tail.Next = right;
                right = right.Next;
            }

            tail = tail.Next;
        }

        if (left != null)
        {
            tail.Next = left;
        }
        else if (right != null)
        {
            tail.Next = right;
        }

        return dummy.Next;
    }
    
    [Fact]
    public void MergedSortedLists_GivenTwoList_MergesThem()
    {
        // Arrange
        var left = new ListNode(1, new ListNode(2, new ListNode(3)));
        var right = new ListNode(0, new ListNode(4));
        var expected = new ListNode(0, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));
        
        // Act
        var actual = MergedSortedLists(left, right);
        
        // Assert
        actual.Should().BeEquivalentTo(expected);
    }
}