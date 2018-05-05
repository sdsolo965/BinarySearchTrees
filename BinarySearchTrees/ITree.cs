using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    public interface ITree<T> where T : IComparable
    {
        bool IsEmpty();
        int Cardinality();
        bool Member(T element);
        NonEmptyBST<T> Add(T element);
        int MaxDepth();
    }
}
