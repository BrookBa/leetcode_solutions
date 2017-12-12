//Problem Link: https://leetcode.com/problems/add-two-numbers/description/

/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        int holder = 0;
        int carry = 0;
        ListNode * head = NULL;
        ListNode * temp = NULL;
        holder = l1 -> val + l2 -> val;
        if(holder >= 10){
            carry = 1;
            holder -= 10;
        }
        head = new ListNode(holder);
        temp = head;
        l1 = l1 -> next;
        l2 = l2 -> next;
        holder = carry;
        carry = 0;
        
        while(l1 || l2){
            if(l1)
                holder += l1 -> val;
            if(l2)
                holder += l2 -> val;
            if(holder >= 10){
                carry = 1;
                holder -= 10;
            }
            temp -> next = new ListNode(holder);
            temp = temp -> next;
            holder = carry;
            carry = 0;
            if(l1)
                l1 = l1 -> next;
            if(l2)
                l2 = l2 -> next;
        }
        if(holder){
            temp -> next = new ListNode(holder);
        }
        return head;
        
        
        
    }
};
