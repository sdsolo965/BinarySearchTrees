using System;

namespace BinarySearchTrees
{
    public class NonEmptyBST<T> : ITree<T> where T : IComparable
    {
        private T data;
        private ITree<T> left;
        private ITree<T> right;
        public NonEmptyBST(T element)
        {
            data = element;
            left = new EmptyBST<T>();
            right = new EmptyBST<T>();
        }

        private NonEmptyBST(T element, ITree<T> leftTree, ITree<T> rightTree)
        {
            data = element;
            left = leftTree;
            right = rightTree;

        }

        public bool IsEmpty()
        {
            return false;
        }

        public int Cardinality()
        {
            return 1 + left.Cardinality() + right.Cardinality();
        }

        public bool Member(T element)
        {
            if (data.Equals(element))
            {
                return true;
            }
            else
            {
                if (element.CompareTo(data) < 0)
                {
                    return left.Member(element);
                }
                else
                {
                    return right.Member(element);
                }
            }
        }

        public NonEmptyBST<T> add(T element)
        {
            if (data.Equals(element))
            {
                return this;
            }
            else
            {
                if (element.CompareTo(data) < 0)
                {
                    return new NonEmptyBST<T>(data, left.add(element), right);
                }
                else
                {
                    return new NonEmptyBST<T>(data, left, right.add(element));
                }
            }
        }

        public int MaxDepth() =>
            1 + (left.MaxDepth() > right.MaxDepth() ? left.MaxDepth() : right.MaxDepth());

        
    }
}