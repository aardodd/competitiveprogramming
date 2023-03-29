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