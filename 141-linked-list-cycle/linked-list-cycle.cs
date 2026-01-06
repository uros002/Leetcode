/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null || head.next == null){
            return false;
        }

        var curr = head;
        var prev = head;

        while(curr != null && curr.next != null){
            prev = prev.next;
            curr = curr.next.next;

            if(prev == curr){
                return true;
            }
        }

        return false;
    }
}