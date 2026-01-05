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
    public ListNode Partition(ListNode head, int x) {
        var smallDummy = new ListNode(0);
        var largeDummy = new ListNode(0);
        
        var curr = head;
        
        var small = smallDummy;
        var large = largeDummy;

        while(curr != null){
            if(curr.val < x){
                small.next = curr;
                small = small.next;
            }else{
                large.next = curr;
                large = large.next;
            }

            curr = curr.next;
        }

        large.next = null;
        small.next = largeDummy.next;

        return smallDummy.next;
    }
}