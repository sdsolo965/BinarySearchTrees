using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            EmptyBST<int> emptyBst = new EmptyBST<int>();
            int totalInputs = Convert.ToInt32(Console.ReadLine());
            int firstInput = Convert.ToInt32(Console.ReadLine());
            NonEmptyBST<int> root = emptyBst.Add(firstInput);
            for (int i = 1; i < totalInputs-1; i++)
            {
                int data = Convert.ToInt32(Console.ReadLine());
                root.Add(data);
            }
            //while (totalInputs-- > 0)
            //{
            //    int data = Convert.ToInt32(Console.ReadLine());
            //    root.Add(data);
            //}

            Console.WriteLine($"This trees max depth is: {root.MaxDepth()} nodes.");
        }
    }
}
