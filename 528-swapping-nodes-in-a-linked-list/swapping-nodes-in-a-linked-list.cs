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
    public ListNode SwapNodes(ListNode head, int k) {
        var first = head;
        
        for(int i = 1; i < k; i++){
            first = first.next;
        }

        var slow = head;
        var fast = first;
        while(fast.next != null){
            slow = slow.next;
            fast = fast.next;
        }

        int temp = first.val;
        first.val = slow.val;
        slow.val = temp;

        return head;

    }
}