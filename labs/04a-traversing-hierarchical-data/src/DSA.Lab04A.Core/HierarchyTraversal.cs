using System;
using System.Collections.Generic;

namespace DSA.Lab04A
{
    /// <summary>
    /// Recursive algorithms over a rooted hierarchy.
    ///
    /// The key idea is structural recursion:
    /// solve the current node, then apply the same operation to each child subtree.
    /// </summary>
    public static class HierarchyTraversal
    {
        public static int CountNodes<T>(HierarchyNode<T> root)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root));
            }

            // TODO: count this node, then count every child subtree.
            
            int count = 1;
            foreach (var child in root.Children)
                count += CountNodes<T>(child);
            
            return count;
        }

        public static bool Contains<T>(HierarchyNode<T> root, T target)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root));
            }

            // TODO: compare the current node, then search child subtrees.
            
            if (EqualityComparer<T>.Default.Equals(root.Value, target))
                return true;

            foreach (var child in root.Children)
                if (Contains<T>(child, target))
                    return true;
            
            return false;
        }

        public static IReadOnlyList<T> DepthFirstPreOrder<T>(HierarchyNode<T> root)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root));
            }

            // TODO: return values in pre-order:
            // current node first, then each child subtree from left to right.
            
            List<T> nodes = new List<T>(){root.Value};

            foreach (var child in root.Children)
                nodes.AddRange(DepthFirstPreOrder<T>(child));

            return nodes;
        }

        public static int MaxDepth<T>(HierarchyNode<T> root)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root));
            }

            // Depth is measured in edges from the root.
            // A single-node tree therefore has max depth 0.
            
            int deepestDepth = -1;
            foreach (var child in root.Children)
                deepestDepth = Math.Max(deepestDepth, MaxDepth<T>(child));
            
            return deepestDepth + 1;
        }
    }
}
