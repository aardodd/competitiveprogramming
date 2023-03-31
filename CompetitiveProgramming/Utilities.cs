namespace CompetitiveProgramming;

public class ListNode
{
    public int Value { get; set; }
    
    public ListNode? Next { get; set; }

    public ListNode(int value = 0, ListNode? next = null)
    {
        this.Value = value;
        this.Next = next;
    }
}

public class TreeNode
{
    public int Value { get; set; }
    
    public TreeNode? Left { get; set; }
    
    public TreeNode? Right { get; set; }

    public TreeNode(int value = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.Value = value;
        this.Left = left;
        this.Right = right;
    }
}