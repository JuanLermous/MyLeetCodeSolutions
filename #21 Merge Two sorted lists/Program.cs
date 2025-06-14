﻿//You are given the heads of two sorted linked lists list1 and list2.

//Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

//Return the head of the merged linked list.

//    Input: list1 = [1,2,4], list2 = [1,3,4]
//Output: [1,1,2,3,4,4]

//Example 2:

//Input: list1 = [], list2 = []
//Output: []

//Example 3:

//Input: list1 = [], list2 = [0]
//Output: [0]



//Constraints:

//    The number of nodes in both lists is in the range [0, 50].
//    -100 <= Node.val <= 100
//    Both list1 and list2 are sorted in non-decreasing order.
//Input: list1 = [1,2,4], list2 = [1,3,4]
//Output: [1,1,2,3,4,4]

//Example 2:

//Input: list1 = [], list2 = []
//Output: []

//Example 3:

//Input: list1 = [], list2 = [0]
//Output: [0]



//Constraints:

//    The number of nodes in both lists is in the range [0, 50].
//    -100 <= Node.val <= 100
//    Both list1 and list2 are sorted in non-decreasing order.

using System.Net;

namespace _21_Merge_Two_sorted_lists

{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            Console.WriteLine(MergeTwoLists(list1,list2));
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }


        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            ListNode head = new ListNode(0);
            ListNode current = head;
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;
            while (list1 != null && list2 != null)
            {

                if (list1.val > list2.val)
                {
                    current.next = list2;
                    list2 = list2.next;

                }
                else
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                current = current.next;
                if (list1 != null)
                    current.next = list1;
                else
                    current.next = list2;

            }
            return head.next;
        }
    }
}
