using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsLib.LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public override string ToString()
        {
            ListNode current = this;
            StringBuilder sb = new StringBuilder();
            do
            {
                sb.Append(current.val);
                current = current.next;
            }
            while (current != null);
           
            var res = sb.ToString().ToCharArray();
            Array.Reverse(res);
            return new string(res);
        }
    }

    public class AddTwoNumbersProblem : IProblem
    {
        /*
            Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            Output: 7 -> 0 -> 8

            Input: (5 -> 4 -> 3) + (5 -> 6 -> 4)
            Output: 0 -> 0 -> 8
         */
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            ListNode resultTailNode = null;
            ListNode currentL1Digit = l1;
            ListNode currentL2Digit = l2;
            bool dischargeOfTens = false;
            do
            {
                int val1 = currentL1Digit != null ? currentL1Digit.val : 0;
                int val2 = currentL2Digit != null ? currentL2Digit.val : 0;
                int digitSum = val1 + val2;
                if (dischargeOfTens)
                {
                    digitSum++;
                }

                if (digitSum >= 10)
                {
                    dischargeOfTens = true;
                    digitSum -= 10;
                }
                else
                {
                    dischargeOfTens = false;
                }

                if (result == null)
                {
                    result = resultTailNode = new ListNode(digitSum);
                }
                else
                {
                    resultTailNode.next = new ListNode(digitSum);
                    resultTailNode = resultTailNode.next;
                }
 
                currentL1Digit = currentL1Digit?.next;
                currentL2Digit = currentL2Digit?.next;
            }
            while (currentL1Digit != null || currentL2Digit != null || dischargeOfTens);

            return result;
        }

        public string Solve()
        {
            ListNode l1 = new ListNode(5);  //{ next = new ListNode(4) { next = new ListNode(3) { next = new ListNode(3) } } };
            ListNode l2 = new ListNode(5); //{ next = new ListNode(6) { next = new ListNode(4) } };
            var sum = AddTwoNumbers(l1, l2);
            
            return sum.ToString();
        }
    }
}
