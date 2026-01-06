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
        if(head == null){
            return null;
        }
        ListNode curr = head;

        while(curr != null && curr.next != null){
            if(dict.ContainsKey(curr)){
                dict[curr]++;
                if(dict[curr] >= 2){
                    return curr;
                }
            }else{
                dict.Add(curr,1);
            }

            curr = curr.next;
            
        }

        return null;


    }
}