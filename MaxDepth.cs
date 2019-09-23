/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public int MaxDepth(TreeNode root) {
     if (root == null)
                return 0;

            return TryToGoDeeperLevel(root);

            int TryToGoDeeperLevel(TreeNode actualNode)
            {
                if (actualNode == null)
                    return 0;
                else
                {
                    var leftDepth = TryToGoDeeperLevel(actualNode.left);
                    var rightDepth = TryToGoDeeperLevel(actualNode.right);

                    return leftDepth < rightDepth ? rightDepth + 1 : leftDepth + 1;
                }
            }
    }
