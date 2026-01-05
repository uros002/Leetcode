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
    public ListNode[] SplitListToParts(ListNode head, int k) {
        var listNodes = new ListNode[k];
       
        var curr = head;
        var length = 0;

        while(curr != null){
            length++;
            curr = curr.next;
        }


        curr = head;

        var baseSize = length / k;
        var extra = length % k;

        for(int i = 0; i < k; i++){
            listNodes[i] = curr;
            int partitionSize = baseSize + (i < extra ? 1 : 0);
            

            for(int j = 0; j < partitionSize - 1; j++){
                if(curr != null){
                    curr = curr.next;
                }
            }

            if(curr != null){
                var next = curr.next;
                curr.next = null;
                curr = next;
            }
        }

        return listNodes;
    }
}