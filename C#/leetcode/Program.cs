/*Q83*/
var solution = new Solution();
Console.WriteLine(solution.DeleteDuplicates(new ListNode(1, new ListNode(1, new ListNode(2)))));

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head is null)
            return null;
        var current = head;
        var next = current.next;
        while (next != null)
        {
            if (current.val != next.val)
            {
                current = next;
                next = next.next;
            }
            else
            {
                current.next = next.next;
                next = current.next;
            }
        }
        return head;
    }
}