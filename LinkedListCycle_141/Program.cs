namespace LinkedListCycle_141;

internal class ListNode
{
    private int val;
    public ListNode next;

    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

internal static class Program {
    
    public static void Main(string[] args)
    {
        
    }
    
    public static bool HasCycle(ListNode head) {

        if(head is null || head.next is null) return false;

        var set = new HashSet<ListNode>();
        
        var temp = head;
        while(temp.next is not null)
        {
            if (set.Contains(temp)) return true;
            
            set.Add(temp);
            temp = temp.next;
        }

        return false;
    }
}