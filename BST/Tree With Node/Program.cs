using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_With_Node
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST  bST = new BST();
            bST.Add(10);
            bST.Add(5);
            bST.Add(8);
            bST.Add(19);
            bST.Add(123);
            bST.Add(85);

            bST.ScanInOrder();

        }
    }
}
