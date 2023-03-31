namespace CompetitiveProgramming;

public class MaxDepthBinaryTreeTests
{
    private static int MaxDepthBinaryTree(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        return 1 + Math.Max(MaxDepthBinaryTree(root.Left), MaxDepthBinaryTree(root.Right));
    }

    [Fact]
    public void MaxDepthBinaryTree_GivenAnEmptyTree_ReturnsZero()
    {
        // Arrange
        TreeNode? input = null;

        // Act
        var actual = MaxDepthBinaryTree(input);

        // Assert
        actual.Should().Be(0);
    }

    [Fact]
    public void MaxDepthBinaryTree_GivenRootNode_ReturnsOne()
    {
        // Arrange
        TreeNode? input = new TreeNode(2);

        // Act
        var actual = MaxDepthBinaryTree(input);

        // Assert
        actual.Should().Be(1);
    }    
    
    [Fact]
    public void MaxDepthBinaryTree_GivenDeepLeftSide_ReturnsLeftDepth()
    {
        // Arrange
        TreeNode? input = new TreeNode(2, new TreeNode(1));

        // Act
        var actual = MaxDepthBinaryTree(input);

        // Assert
        actual.Should().Be(2);
    }
    
    [Fact]
    public void MaxDepthBinaryTree_GivenDeepRightSide_ReturnsRightDepth()
    {
        // Arrange
        TreeNode? input = new TreeNode(2, null, new TreeNode(3));

        // Act
        var actual = MaxDepthBinaryTree(input);

        // Assert
        actual.Should().Be(2);
    }
}