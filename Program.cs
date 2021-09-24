using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableandBST.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Display();
            Console.ReadLine();
        }
    }
}