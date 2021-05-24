using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetativeCoding
{
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
    class LinkedListReversal
    {
        public void ReverseList(ListNode head)
        {
            int count = 0;
            while (head.next != null)
            {
                ListNode root = new ListNode();
                root = head.next;
                root.next = head;
                head = head.next;
                if (count == 0)
                {
                    root.next.next = null;
                }
                count++;
            }
        }
        static void Main(string[] args)
        {
            LinkedListReversal t = new LinkedListReversal();
            ListNode list = new ListNode();
            ListNode list2 = new ListNode();
            ListNode list3 = new ListNode();
            ListNode list4 = new ListNode();
            list.val = 1;
            list.next = list2;
            list2.val = 2;
            list2.next = list3;
            list3.val = 3;
            list3.next = list4;
            list4.val = 4;
            list4.next = null;
            t.ReverseList(list);
        }
    }
}
