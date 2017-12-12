//Problem Link: https://leetcode.com/problems/merge-two-binary-trees/description/

/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 */
class Solution {
public:
    TreeNode* mergeTrees(TreeNode* t1, TreeNode* t2) {
        if(!t1 && !t2){
            return NULL;
        }
        int val = 0;
        if(t1/* && t1->val != NULL*/)
            val += t1 -> val;
        if(t2/* && t2->val != NULL*/)
            val += t2 -> val;
        TreeNode * head = new TreeNode(val);
        if(t1 && t1->left && t2 && t2 -> left)
            head -> left = mergeTrees(t1->left, t2->left);
        else if(t1 && t1->left)
            head ->left = mergeTrees(t1->left, NULL);
        else if(t2 && t2->left)
            head -> left = mergeTrees(NULL, t2->left);
        if(t1&& t2&&t1->right && t2->right)
            head -> right = mergeTrees(t1->right, t2->right);
        else if(t1&&t1->right)
            head -> right = mergeTrees(t1->right, NULL);
        else if(t2&&t2->right)
            head -> right = mergeTrees(NULL, t2->right);
        return head;
    }
};
