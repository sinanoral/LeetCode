namespace RemoveLinkedListElements_203;

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

internal static class Program
{
    static void Main()
    {

    }
    private static ListNode RemoveElements(ListNode head, int val)
    {

        if (head == null) return head;

        ListNode temp = new ListNode(0);
        temp.next = head;

        ListNode curr = head;
        ListNode prev = temp;
        while (curr != null)
        {
            if (curr.val == val)
            {
                prev.next = curr.next;
            }
            else
            {
                prev = curr;
            }

            curr = curr.next;
        }

        return temp.next;
    }

}