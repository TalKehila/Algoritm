using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEx
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            

            LinkedList list2 = new LinkedList();
            LinkedList list1 = new LinkedList();

            list1.Insert(5);         
            list1.Insert(6);
            list1.Insert(7);
            list1.Insert(8);
            list1.Insert(13);
            list1.Insert(10);
            list1.Insert(11);
            list1.Insert(12);

            list1.Delete(10); // delete

            list2.Insert(14);
            list2.Insert(15);
            list2.Insert(16);

           /* Console.WriteLine(new LinkedList().ToString());*/// option to call a empty list 
            Console.WriteLine("list 1 : " + list1);
            Console.WriteLine("list 2 : " + list2);
            LinkedList mergedList = LinkedList.Merge(list1, list2);
            Console.WriteLine("Merged List: " + mergedList);

            // section 4
            LinkedList exmplelist1 = new LinkedList();
            LinkedList exmplelist2 = new LinkedList();

            for (int i = 1; i <= 9; i+=2)
            {
                exmplelist1.Insert(i);
            }
            for (int i = 0; i <= 8; i +=2)
            {
                exmplelist2.Insert(i);
            }
            LinkedList mergedexmpleList = LinkedList.Merge(exmplelist1, exmplelist2);

            Console.WriteLine(" exmple list 1 :" + exmplelist1);
            Console.WriteLine(" exmple list 2 :" + exmplelist2);
            Console.WriteLine(" merge of the two exmple list will start now");
            if (mergedexmpleList != null)
            {
                Console.WriteLine("Success : " + mergedexmpleList);
            }
            else
            {
                Console.WriteLine(" nope it didnt success");
            }



        }
    }


}

