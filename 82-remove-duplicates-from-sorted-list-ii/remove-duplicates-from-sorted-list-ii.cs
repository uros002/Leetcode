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
    public ListNode DeleteDuplicates(ListNode head) {
        var dummy = new ListNode(0);

        dummy.next = head;
        var fast = head;
        var slow = dummy;
        
        while(fast != null){
            var flag = false;

            while(fast.next != null && fast.next.val == fast.val){
                flag = true;
                fast = fast.next;
            }

            if(flag){
                slow.next = fast.next;
            }else{
                slow = slow.next;
            }

            fast = fast.next;
        }

        return dummy.next;

    }
}