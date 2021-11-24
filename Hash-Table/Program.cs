using HashTable.BinarySearchTree;
using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree Demo");
            BinarySearchTree<int> Binary = new BinarySearchTree<int>(56);
            Binary.Insert(30);
            Binary.Insert(70);
            Binary.Display();
            Binary.GetSize();
        }
    }
}
