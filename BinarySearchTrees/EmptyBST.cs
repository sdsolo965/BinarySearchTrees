using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    class EmptyBST<T> : ITree<T> where T : IComparable
    {
        public bool IsEmpty()
        {
            return true;
        }

        public int Cardinality()
        {
            return 0;
        }

        public bool Member(T element)
        {
            return false;
        }

        public NonEmptyBST<T> Add(T element)
        {
            return new NonEmptyBST<T>(element);
        }

        public int MaxDepth()
        {
            return 0;
        }
    }
}
