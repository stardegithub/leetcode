// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
//
// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
//
//
// Example
//
// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
// Output: 7 -> 0 -> 8
// Explanation: 342 + 465 = 807.
//
//


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
//         int num1 = 0;
//         int num2 = 0;
//         while(l1.next !=null)
//         {
//             num1 = num1 + l1.val * (int)Math.Pow(10,num1/10);
//             l1 = l1.next;
//         }
//         while(l2.next !=null)
//         {
//             num2 = num2 + l2.val * (int)Math.Pow(10,num2/10);
//             l2 = l2.next;
//         }
//         int final = num1 +num2;
//         ListNode finalNode = new ListNode(0);
//         ListNode TempNode = finalNode;
//         while(final != 0)
//         {
//             TempNode.val = final%10;
//             final = final /10;
//             TempNode.next = new ListNode(0);
//             TempNode = TempNode.next;   
//         }
        
//         return finalNode;
        ListNode finalNode = new ListNode(0);
        bool isadd = false;
        ListNode TempNode = finalNode;
        while(l1 != null || l2 != null || isadd)
        {   
            
            int l1val = l1 == null ? 0:l1.val;
            int l2val = l2 == null ? 0:l2.val;
            TempNode.val = isadd ? l1val +l2val +1 : l1val +l2val ;
            isadd = false;
            
            if(TempNode.val>=10)
            {
                TempNode.val = TempNode.val%10;
                isadd = true;
            }
            l1 = l1 != null ? l1.next : null;
            l2 = l2 != null ? l2.next : null;
            if(l1 == null && l2 == null && !isadd )
            {
                break;
            }
            TempNode.next = new ListNode(0);
            TempNode = TempNode.next;
           
        }
        return finalNode;
    }
}
