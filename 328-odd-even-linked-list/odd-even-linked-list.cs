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
    public ListNode OddEvenList(ListNode head) {
        var blueDummy = new ListNode(0);
        var redDummy = new ListNode(0);

        var blue = blueDummy;
        var red = redDummy;

        var blueFlag = true;

        var curr = head;

        while(curr != null){
            if(blueFlag){
                blue.next = curr;
                blue = blue.next;
            }else{
                red.next = curr;
                red = red.next;

            }

            blueFlag = !blueFlag;
            curr = curr.next;
        }

        red.next = null;
        blue.next = redDummy.next;

        return blueDummy.next;
    }
}