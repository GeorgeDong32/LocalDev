ListNode l1 = new ListNode(5, null);
ListNode l2 = new ListNode(5, null);

var result = new Solution().AddTwoNumbers(l1, l2);

while (result != null)
{
    Console.Write(result.val);
    result = result.next;
}

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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var temp1 = l1; var temp2 = l2;
        var sum = 0; var carry = 0;
        var first = 1;
        ListNode result = null;
        ListNode current = null;
        bool end = true;
        do
        {
            sum = (temp1.val + temp2.val + carry) % 10;
            carry = (temp1.val + temp2.val + carry) / 10;
            if (first == 1)
            {
                result = new ListNode(sum);
                first = 0;
                current = result;
            }
            else
            {
                current.next = new ListNode(sum);
                current = current.next;
            }
            if (temp1.next == null && temp2.next == null && carry == 0)
            {
                end = false;
            }
            if (temp1.next == null)
                temp1.next = new ListNode();
            if (temp2.next == null)
                temp2.next = new ListNode();
            temp1 = temp1.next;
            temp2 = temp2.next;
        }
        while ((temp1 != null || temp2 != null) && end);


        return result;
    }
}
