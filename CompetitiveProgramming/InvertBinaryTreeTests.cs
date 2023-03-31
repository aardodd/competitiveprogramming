namespace CompetitiveProgramming;

public class InvertBinaryTreeTests
{
    private static TreeNode? InvertBinaryTree(TreeNode? root)
    {
        if (root == null)
        {
            return null;
        }

        (root.Left, root.Right) = (root.Right, root.Left);

        InvertBinaryTree(root.Left);
        InvertBinaryTree(root.Right);

        return root;
    }

    [Fact]
    public void InvertBinaryTree_GivenAValidTree_ReturnsTheInverse()
    {
        // Arrange
        var input = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        var expected = new TreeNode(2, new TreeNode(3), new TreeNode(1));

        // Act
        var actual = InvertBinaryTree(input);

        // Assert
        actual.Should().BeEquivalentTo(expected);
    }
}