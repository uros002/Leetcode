/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public void ReorderList(ListNode head) {
        var slow = head;
        var fast = head;

        while(fast!=null && fast.next!= null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode prev = null;
        var curr = slow.next;
        slow.next = null;

        while(curr != null){
            var nextTemp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextTemp;
        }

        var first = head;
        var second = prev;

        while(second != null){
            var temp1 = first.next;
            var temp2 = second.next;

            first.next = second;
            second.next = temp1;    

            first = temp1;
            second = temp2;

        }


    }
}