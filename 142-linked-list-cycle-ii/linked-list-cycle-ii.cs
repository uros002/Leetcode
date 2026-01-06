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
    public ListNode DetectCycle(ListNode head) {
        
        var dict = new Dictionary<ListNode,int>();
        var hash = new HashSet<ListNode>();
        if(head == null){
            return null;
        }
        ListNode curr = head;

        while(curr != null && curr.next != null){
            if(hash.Contains(curr)){
                return curr;
            }else{
                hash.Add(curr);
            }

            curr = curr.next;
            
        }

        return null;


    }
}