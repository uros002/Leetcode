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
    public ListNode SwapPairs(ListNode head) {
        var dummy = new ListNode(0);
        dummy.next = head;

        var prev = dummy;

        while(prev.next != null && prev.next.next != null){
            var first = prev.next;
            var second = first.next;

            first.next = second.next;
            second.next = prev.next;
            prev.next = second;

            prev = first;
        }
        return dummy.next;
    }
}