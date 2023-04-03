namespace CompetitiveProgramming;

public class DiameterBinaryTreeTests
{
    private static int DiameterBinaryTree(TreeNode root)
    {
        return DepthFirstSearch(root).Item2;
    }

    private static (int, int) DepthFirstSearch(TreeNode? root, int maxDepth = 0)
    {
        if (root == null)
        {
            return (-1, maxDepth);
        }

        var left = 1 + DepthFirstSearch(root.Left).Item1;
        var right = 1 + DepthFirstSearch(root.Right).Item1;

        maxDepth = Math.Max(maxDepth, left + right);
        
        return (Math.Max(left, right), maxDepth);
    }

    [Fact]
    public void DiameterBinaryTree_GivenValidTree_ReturnsDiameter()
    {
        // Arrange
        var input = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3));

        // Act
        var actual = DiameterBinaryTree(input);

        // Assert
        actual.Should().Be(3);
    }
}