namespace CompetitiveProgramming;

public class ReverseLinkedListTests
{
    private static ListNode ReverseLinkedListIterative(ListNode list)
    {
        ListNode previousNode = null;
        var currentNode = list;

        while (currentNode != null)
        {
            var temp = currentNode.Next;
            currentNode.Next = previousNode;
            previousNode = currentNode;
            currentNode = temp;
        }

        return previousNode;
    }

    private static ListNode? ReverseLinkedListRecursive(ListNode? list)
    {
        if (list == null)
        {
            return null;
        }

        var newList = list;
        if (list.Next != null)
        {
            newList = ReverseLinkedListRecursive(list.Next);
            list.Next.Next = list;
        }

        list.Next = null;
        return newList;
    }

    [Fact]
    public void ReverseLinkedListIterative_GivenAList_ReversesIt()
    {
        // Arrange
        var input = new ListNode(1, new ListNode(2, new ListNode(3)));
        var expected = new ListNode(3, new ListNode(2, new ListNode(1)));
        
        // Act
        var actual = ReverseLinkedListIterative(input);
        
        // Assert
        actual.Should().BeEquivalentTo(expected);
    }
    
    [Fact]
    public void ReverseLinkedListRecursive_GivenAnEmptyList_ReturnsNull()
    {
        // Arrange
        ListNode? input = null;
        
        // Act
        var actual = ReverseLinkedListRecursive(input);
        
        // Assert
        actual.Should().BeNull();
    }
    
    [Fact]
    public void ReverseLinkedListRecursive_GivenAList_ReversesIt()
    {
        // Arrange
        var input = new ListNode(1, new ListNode(2, new ListNode(3)));
        var expected = new ListNode(3, new ListNode(2, new ListNode(1)));
        
        // Act
        var actual = ReverseLinkedListRecursive(input);
        
        // Assert
        actual.Should().BeEquivalentTo(expected);
    }
}