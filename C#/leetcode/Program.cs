var solution = new Solution();
ListNode l1 = null; ListNode l2 = null;
var l3 = new ListNode(1, new ListNode(2, new ListNode(4, null)));
var l4 = new ListNode(1, new ListNode(3, new ListNode(4, null)));
ListNode l5 = null; var l6 = new ListNode(0, null);

Console.WriteLine(solution.MergeTwoLists(l1, l2));
Console.WriteLine(solution.MergeTwoLists(l3, l4));
Console.WriteLine(solution.MergeTwoLists(l5, l6));

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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null || list2 == null)
        {
            return (list1 == null) ? list2 : list1;
        }
        else
        {
            if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                GC.Collect();
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list2.next, list1);
                GC.Collect();
                return list2;
            }
        }
    }
}