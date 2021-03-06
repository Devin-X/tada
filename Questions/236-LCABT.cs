﻿using System;
namespace questions
{
    public class LCABT
    {
        //Question URL: https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/description/

        //Given a binary tree, find the lowest common ancestor(LCA) of two given nodes in the tree.

        //According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between 
        //two nodes v and w as the lowest node in T that has both v and w as descendants (where we allow a node to be a descendant of itself).”

        //        _______3______
        //       /              \
        //    ___5__          ___1__
        //   /      \        /      \
        //   6      _2       0       8
        //         /  \
        //         7   4
        //For example, the lowest common ancestor(LCA) of nodes 5 and 1 is 3. Another example is LCA 
        //of nodes 5 and 4 is 5, since a node can be a descendant of itself according to the LCA definition.

        public static TreeNode LowestCommonAncestor_EPI(TreeNode root, int p, int q)
        {
            if (root == null)
            {
                return null;
            }
            else if (root.val == p || root.val == q)
            {
                return root;
            }

            var l_res = LowestCommonAncestor_EPI(root.left, p, q);
            var r_res = LowestCommonAncestor_EPI(root.right, p, q);

            if (l_res != null && r_res != null)
            {
                return root;
            }

            return l_res != null ? l_res : r_res;
        }
    }
}
