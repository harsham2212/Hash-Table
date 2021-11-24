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
            Binary.Insert(72);
            Binary.Insert(40);
            Binary.Insert(60);
            Binary.Insert(95);
            Binary.Insert(11);
            Binary.Insert(65);
            Binary.Insert(31);
            Binary.Insert(16);
            Binary.Insert(63);
            Binary.Insert(67);
            Binary.Display();
            //Binary.GetSize();
        }
    }
}
