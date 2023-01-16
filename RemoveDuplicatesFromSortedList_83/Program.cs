﻿namespace RemoveDuplicatesFromSortedList_83;

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

    private static ListNode DeleteDuplicates(ListNode head)
    {
        ListNode temp = head;
        while (temp != null && temp.next != null)
        {
            if (temp.val == temp.next.val)
            {
                temp.next = temp.next.next;
            }
            else
            {
                temp = temp.next;
            }
        }

        return head;
    }
}
